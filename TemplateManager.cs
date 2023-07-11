using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Spotistat.Spotistat;

namespace Spotistat
{
    internal class TemplateManager
    {
        private string path;
        private readonly Spotistat form;
        public TemplateManager(Spotistat form)
        {
            this.form = form;

            path = Properties.Settings.Default.path;
            EnsureCreated();
        }
        public void RewriteJson(List<Template> templates)
        {
            string json = JsonConvert.SerializeObject(templates, Formatting.Indented);

            File.SetAttributes(path, FileAttributes.Normal);
            File.WriteAllText(path, json);
            File.SetAttributes(path, FileAttributes.ReadOnly | FileAttributes.Hidden);
        }
        private void EnsureCreated()
        {
            // Choosing a folder for templates is JSON does not exist
            if (!File.Exists(path))
            {
                form.listbox.Enabled = false;

                FolderBrowserDialog fbd = new FolderBrowserDialog
                {
                    Description = "Select a folder where templates will be located"
                };

                // Setting and memorizing the path
                if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Properties.Settings.Default.path = fbd.SelectedPath + "\\templates.json";
                    Properties.Settings.Default.Save();

                    path = Properties.Settings.Default.path;
                }
                else Environment.Exit(1);

                File.Create(path);
                File.SetAttributes(path, FileAttributes.ReadOnly | FileAttributes.Hidden);
            }
        }
        public List<Template> GetTemplates()
        {
            try
            {
                string templatesJson = File.ReadAllText(path);
                List<Template> templates = JsonConvert.DeserializeObject<List<Template>>(templatesJson);
                return templates;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void DeleteTemplate(string name)
        {
            List<Template> templates = GetTemplates();
            foreach (Template template in templates.ToList())
            {
                if (template.Name == name) templates.Remove(template);
            }

            RewriteJson(templates);
        }
        public void SaveTemplate(List<Template> templates, string id, string name)
        {
            if (templates == null)
            {
                templates = new List<Template>();
            }
            else if (templates.Exists(x => x.ID == id))
            {
                MessageBox.Show("Template already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Template newTemplate = new Template(id, name);
            templates.Add(newTemplate);

            RewriteJson(templates);

            MessageBox.Show("Template saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
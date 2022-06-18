using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TestLocalizzazione
{
    public partial class Form1 : Form
    {
        readonly ResourceManager _manager;

        public Form1()
        {
            InitializeComponent();

            _manager = new ResourceManager("TestLocalizzazione.Resource", typeof(Form1).Assembly);

            string culture = Thread.CurrentThread.CurrentCulture.ToString();
            string uiCulture = Thread.CurrentThread.CurrentUICulture.ToString();

            labelCulture.Text = culture;
            labelUICulture.Text = uiCulture;

            UpdateLabel();
        }

        private void SetCulture(CultureInfo cultureInfo)
        {
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            labelTranslationCulture.Text = cultureInfo.ToString();

            UpdateLabel();
        }

        private void UpdateLabel()
            => labelTranslation.Text = _manager.GetString("TRADUZIONE");

        private void radioButtonEnglish_CheckedChanged(object sender, EventArgs e)
        {
            SetCulture(new CultureInfo("en-US"));
        }

        private void radioButtonItalian_CheckedChanged(object sender, EventArgs e)
        {
            SetCulture(new CultureInfo("it-IT"));
        }

        private void radioButtonDeutch_CheckedChanged(object sender, EventArgs e)
        {
            SetCulture(new CultureInfo("de-DE"));
        }

        private void radioButtonSpanish_CheckedChanged(object sender, EventArgs e)
        {
            SetCulture(new CultureInfo("es-ES"));
        }

        private void radioButtonMalta_CheckedChanged(object sender, EventArgs e)
        {
            SetCulture(new CultureInfo("mt-MT"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque_projeto_integradora
{
    public partial class FrmPrincipalOficial : Form
    {
        //fields 
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;

        public FrmPrincipalOficial()
        {
            InitializeComponent();
            random = new Random();
        }

        //methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender !=null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    paneltitlebar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimeiraCor = color;
                    ThemeColor.SegundaCor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activateForm!=null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbltitle.Text = childForm.Text;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Pedidos(), sender);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}

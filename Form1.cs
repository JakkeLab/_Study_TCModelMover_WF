using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trimble.Connect.Desktop.API;
using Trimble.Connect.Desktop.API.Models;
using Trimble.Connect.Desktop.API.Projects;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TCModelMover_WF
{

    public partial class Form1 : Form
    {
        TC TCAction = new TC();
        bool Connected = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            lb_Status.Text = "Connecting";
            Connected = TCAction.Connect();
            if(Connected)
            {
                lb_Status.Text = "Connected";
            }
            else
            {
                lb_Status.Text = "Disconnected";
            }
        }
        private void bt_Disconnect_Click(object sender, EventArgs e)
        {
            TCAction.Disconnect();
            Connected = false;
            lb_Status.Text = "Disconnected";
        }

        private void bt_GetActiveProj_Click(object sender, EventArgs e)
        {
            string ProjectName;
            if(Connected && TCAction.getActiveProject() != null) 
            {
                ProjectName = TCAction.getProjectName(TCAction.getActiveProject());
                tb_ActiveProject.Text = ProjectName;
            }
            else
            {
                MessageBox.Show("No project opened");
            }
        }

        private void bt_getModelName_Click(object sender, EventArgs e)
        {
            tb_getModelName.Text = TCAction.getSelectedObjectName(TCAction.getActiveProject());
        }

        private void bt_MoveObj_Click(object sender, EventArgs e)
        {
            double moveX;
            double moveY;
            double moveZ;
            Double.TryParse(tb_MoveX.Text, out moveX);
            Double.TryParse(tb_MoveY.Text, out moveY);
            Double.TryParse(tb_MoveZ.Text, out moveZ);

            try
            {
                TCAction.MoveObjects(TCAction.getActiveProject(), moveX, moveY, moveZ);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void tb_OnlyNum(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar)) && e.KeyChar != '.' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
    public class TC
    {
        private readonly TrimbleConnectDesktopClient client = new TrimbleConnectDesktopClient();
        public string Text;
        private bool connected = false;
        
        public bool Connect()
        {
            this.connected = this.client.Connect();
            return this.connected;

        }

        public void Disconnect()
        {
            this.client.Disconnect();
            this.connected = false;
        }

        public Project getActiveProject()
        {
            if (this.connected)
            {
                var activeProject = this.client.ProjectManager.GetActiveProject();
                return activeProject;
            }
            else
            {
                return null;
            }
        }

        public string getProjectName(Project project)
        {
            if (project != null)
            {
                return project.Name;
            }
            else
            {
                return null;
            }
        }

        public string getSelectedObjectName(Project project)
        {
            project.ModelObjectManager.ModelObjectSelectionChanged += this.ModelObjectSelectionChangedOnModelLevel;
            var models = project.ModelManager.GetLoadedModels().ToList();
            Model model;
            if (models.Any())
            {
                model = models.First();
                model.ModelObjectManager.ModelObjectSelectionChanged += this.ModelObjectSelectionChangedOnModelLevel;
                return model.Name;
            }
            else
            {
                model = null;
                return null;
            }
        }

        public void MoveObjects(Project project, double moveX, double moveY, double moveZ)
        {
            var models = project.ModelManager.GetLoadedModels().ToList();
            foreach(Model model in models)
            {
                model.SetPosition(moveX, moveY, moveZ);
            }
        }

        private void ModelObjectSelectionChangedOnProjectLevel(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Model object selection was changed on project level!");
        }

        private void ModelObjectSelectionChangedOnModelLevel(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Model object selection was changed on model level!");
        }

    }
}

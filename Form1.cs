namespace Dotnet02;

public partial class Form1 : Form
{
   private Label lblName;
        private TextBox txtName;

        private Label lblAddress;
        private TextBox txtAddress;

        private GroupBox groupBoxGender;
        private RadioButton rbMale;
        private RadioButton rbFemale;

        private GroupBox groupBoxExpertise;
        private RadioButton rbCSharp;
        private RadioButton rbDotNet;
        

        private Button btnSubmit;
    public Form1()
    {
        InitializeComponent();
       // Form settings
            this.Text = "WinForms Example Form";
            this.Size = new System.Drawing.Size(800, 500);

            // Name
            lblName = new Label();
            lblName.Text = "Name:";
            lblName.Location = new System.Drawing.Point(20, 20);
            txtName = new TextBox();
            txtName.Location = new System.Drawing.Point(120, 20);

            // Address
            lblAddress = new Label();
            lblAddress.Text = "Address:";
            lblAddress.Location = new System.Drawing.Point(20, 60);
            txtAddress = new TextBox();
            txtAddress.Location = new System.Drawing.Point(120, 60);

            // Gender
            groupBoxGender = new GroupBox();
            groupBoxGender.Text = "Gender";
            groupBoxGender.Location = new System.Drawing.Point(20, 100);
            rbMale = new RadioButton();
            rbMale.Text = "Male";
            rbMale.Location = new System.Drawing.Point(10, 20);
            rbFemale = new RadioButton();
            rbFemale.Text = "Female";
            rbFemale.Location = new System.Drawing.Point(120, 20);
            groupBoxGender.Controls.Add(rbMale);
            groupBoxGender.Controls.Add(rbFemale);

            // Expertise
            groupBoxExpertise = new GroupBox();
            groupBoxExpertise.Text = "Programming Expertise";
            groupBoxExpertise.Location = new System.Drawing.Point(20, 200);
            rbCSharp = new RadioButton();
            rbCSharp.Text = "C#";
            rbCSharp.Location = new System.Drawing.Point(20, 40);
            rbDotNet = new RadioButton();
            rbDotNet.Text = "DotNet";
            rbDotNet.Location = new System.Drawing.Point(130, 40);
            groupBoxExpertise.Controls.Add(rbCSharp);
            groupBoxExpertise.Controls.Add(rbDotNet);

            //List
            ListBox mylist = new ListBox(); 
            mylist.Location = new  System.Drawing.Point(300, 100); 
            mylist.Size = new Size(80, 95); 
            mylist.ForeColor = Color.Purple; 
            mylist.Items.Add("Kathmandu"); 
            mylist.Items.Add("Bhaktapur"); 
            mylist.Items.Add("Pokhara");

            // Submit button
            btnSubmit = new Button();
            btnSubmit.Text = "Submit";
            btnSubmit.Location = new System.Drawing.Point(150, 300);
            btnSubmit.Click += btnSubmit_Click;

            // Add controls to the form
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(groupBoxGender);
            Controls.Add(groupBoxExpertise);
            Controls.Add(btnSubmit);
            Controls.Add(mylist);
        }
         private void btnSubmit_Click(object? sender, EventArgs e)
        {
        //  string name = txtName.Text;
        //     string address = txtAddress.Text;
        //     string gender = rbMale.Checked ? "Male" : "Female";
        //     string expertise = rbCSharp.Checked ? "C#" : "DotNet";

        //     System.Console.WriteLine(name+" "+address+" "+gender+" "+expertise);
            
        System.Console.WriteLine("hello");
        }
    }

 


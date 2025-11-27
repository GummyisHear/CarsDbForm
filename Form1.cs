using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Data;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    private readonly CarsDbContext _db;

    public Form1()
    {
        InitializeComponent();
        _db = new();
        using (var db = new CarsDbContext())
        {
            db.EnsureCreated();
        }

        LoadOwners();
    }

    public void InitializeComponent()
    {
        tabControl1 = new TabControl();
        ownersPage = new TabPage();
        carsPage = new TabPage();
        servicesPage = new TabPage();
        ownersDataGridView = new DataGridView();
        tabControl1.SuspendLayout();
        ownersPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)ownersDataGridView).BeginInit();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(ownersPage);
        tabControl1.Controls.Add(carsPage);
        tabControl1.Controls.Add(servicesPage);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Location = new Point(0, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(800, 450);
        tabControl1.TabIndex = 0;
        // 
        // ownersPage
        // 
        ownersPage.Controls.Add(ownersDataGridView);
        ownersPage.Location = new Point(4, 24);
        ownersPage.Name = "ownersPage";
        ownersPage.Padding = new Padding(3);
        ownersPage.Size = new Size(792, 422);
        ownersPage.TabIndex = 0;
        ownersPage.Text = "Omanikud";
        ownersPage.UseVisualStyleBackColor = true;
        // 
        // carsPage
        // 
        carsPage.Location = new Point(4, 24);
        carsPage.Name = "carsPage";
        carsPage.Padding = new Padding(3);
        carsPage.Size = new Size(792, 422);
        carsPage.TabIndex = 1;
        carsPage.Text = "Autod";
        carsPage.UseVisualStyleBackColor = true;
        // 
        // servicesPage
        // 
        servicesPage.Location = new Point(4, 24);
        servicesPage.Name = "servicesPage";
        servicesPage.Size = new Size(792, 422);
        servicesPage.TabIndex = 2;
        servicesPage.Text = "Hooldus ja Teenused";
        servicesPage.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        ownersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ownersDataGridView.Location = new Point(8, 217);
        ownersDataGridView.Name = "dataGridView1";
        ownersDataGridView.Size = new Size(776, 197);
        ownersDataGridView.TabIndex = 0;
        // 
        // Form1
        // 
        ClientSize = new Size(800, 450);
        Controls.Add(tabControl1);
        Name = "Form1";
        Text = "Form1";
        tabControl1.ResumeLayout(false);
        ownersPage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)ownersDataGridView).EndInit();
        ResumeLayout(false);
    }

    private TabControl tabControl1;
    private TabPage ownersPage;
    private TabPage servicesPage;
    private DataGridView ownersDataGridView;
    private TabPage carsPage;

    private void LoadOwners()
    {
        var tooted = _db.Owners.Include(i => i.Cars).Select(i => new
        {
            i.Id,
            i.FullName,
            i.Phone,
            Cars = i.Cars.Count == 0 ? "None" : i.Cars.ToCommaSepString(", "),
        }).ToList();

        ownersDataGridView.DataSource = tooted;

        //if (ownersDataGridView.Columns["KategooriaId"] != null)
        //    ownersDataGridView.Columns["KategooriaId"].Visible = false;
    }
}

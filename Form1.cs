using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

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
        pictureBox1 = new PictureBox();
        owner_deleteBtn = new Button();
        owner_lisaBtn = new Button();
        comboBox1 = new ComboBox();
        label3 = new Label();
        label2 = new Label();
        owner_phone = new TextBox();
        label1 = new Label();
        owner_fullName = new TextBox();
        ownersDataGridView = new DataGridView();
        carsPage = new TabPage();
        button2 = new Button();
        button1 = new Button();
        car_deleteBtn = new Button();
        car_addBtn = new Button();
        comboBox2 = new ComboBox();
        label8 = new Label();
        label7 = new Label();
        car_model = new Label();
        label5 = new Label();
        label4 = new Label();
        textBox3 = new TextBox();
        textBox1 = new TextBox();
        car_brand = new TextBox();
        servicesPage = new TabPage();
        tabControl1.SuspendLayout();
        ownersPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ownersDataGridView).BeginInit();
        carsPage.SuspendLayout();
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
        ownersPage.Controls.Add(pictureBox1);
        ownersPage.Controls.Add(owner_deleteBtn);
        ownersPage.Controls.Add(owner_lisaBtn);
        ownersPage.Controls.Add(comboBox1);
        ownersPage.Controls.Add(label3);
        ownersPage.Controls.Add(label2);
        ownersPage.Controls.Add(owner_phone);
        ownersPage.Controls.Add(label1);
        ownersPage.Controls.Add(owner_fullName);
        ownersPage.Controls.Add(ownersDataGridView);
        ownersPage.Location = new Point(4, 24);
        ownersPage.Name = "ownersPage";
        ownersPage.Padding = new Padding(3);
        ownersPage.Size = new Size(792, 422);
        ownersPage.TabIndex = 0;
        ownersPage.Text = "Omanikud";
        ownersPage.UseVisualStyleBackColor = true;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.owner;
        pictureBox1.Location = new Point(542, 11);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(200, 200);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 10;
        pictureBox1.TabStop = false;
        // 
        // owner_deleteBtn
        // 
        owner_deleteBtn.Font = new Font("Segoe UI", 12F);
        owner_deleteBtn.Location = new Point(205, 182);
        owner_deleteBtn.Name = "owner_deleteBtn";
        owner_deleteBtn.Size = new Size(100, 29);
        owner_deleteBtn.TabIndex = 9;
        owner_deleteBtn.Text = "Kustuta";
        owner_deleteBtn.UseVisualStyleBackColor = true;
        owner_deleteBtn.Click += owner_deleteBtn_Click;
        // 
        // owner_lisaBtn
        // 
        owner_lisaBtn.Font = new Font("Segoe UI", 12F);
        owner_lisaBtn.Location = new Point(99, 182);
        owner_lisaBtn.Name = "owner_lisaBtn";
        owner_lisaBtn.Size = new Size(100, 29);
        owner_lisaBtn.TabIndex = 8;
        owner_lisaBtn.Text = "Lisa";
        owner_lisaBtn.UseVisualStyleBackColor = true;
        owner_lisaBtn.Click += owner_lisaBtn_Click;
        // 
        // comboBox1
        // 
        comboBox1.Font = new Font("Segoe UI", 12F);
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(105, 113);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(200, 29);
        comboBox1.TabIndex = 7;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        label3.Location = new Point(47, 116);
        label3.Name = "label3";
        label3.Size = new Size(52, 21);
        label3.TabIndex = 6;
        label3.Text = "Autod";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        label2.Location = new Point(40, 78);
        label2.Name = "label2";
        label2.Size = new Size(59, 21);
        label2.TabIndex = 4;
        label2.Text = "Telefon";
        // 
        // owner_phone
        // 
        owner_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        owner_phone.Location = new Point(105, 75);
        owner_phone.Name = "owner_phone";
        owner_phone.Size = new Size(200, 29);
        owner_phone.TabIndex = 3;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        label1.Location = new Point(26, 43);
        label1.Name = "label1";
        label1.Size = new Size(66, 21);
        label1.TabIndex = 2;
        label1.Text = "Täisnimi";
        // 
        // owner_fullName
        // 
        owner_fullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        owner_fullName.Location = new Point(105, 40);
        owner_fullName.Name = "owner_fullName";
        owner_fullName.Size = new Size(200, 29);
        owner_fullName.TabIndex = 1;
        // 
        // ownersDataGridView
        // 
        ownersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ownersDataGridView.Location = new Point(8, 217);
        ownersDataGridView.Name = "ownersDataGridView";
        ownersDataGridView.Size = new Size(776, 197);
        ownersDataGridView.TabIndex = 0;
        // 
        // carsPage
        // 
        carsPage.Controls.Add(button2);
        carsPage.Controls.Add(button1);
        carsPage.Controls.Add(car_deleteBtn);
        carsPage.Controls.Add(car_addBtn);
        carsPage.Controls.Add(comboBox2);
        carsPage.Controls.Add(label8);
        carsPage.Controls.Add(label7);
        carsPage.Controls.Add(car_model);
        carsPage.Controls.Add(label5);
        carsPage.Controls.Add(label4);
        carsPage.Controls.Add(textBox3);
        carsPage.Controls.Add(textBox1);
        carsPage.Controls.Add(car_brand);
        carsPage.Location = new Point(4, 24);
        carsPage.Name = "carsPage";
        carsPage.Padding = new Padding(3);
        carsPage.Size = new Size(792, 422);
        carsPage.TabIndex = 1;
        carsPage.Text = "Autod";
        carsPage.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Font = new Font("Segoe UI", 24F);
        button2.Location = new Point(25, 167);
        button2.Name = "button2";
        button2.Size = new Size(75, 75);
        button2.TabIndex = 17;
        button2.Text = "<";
        button2.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 24F);
        button1.Location = new Point(686, 167);
        button1.Name = "button1";
        button1.Size = new Size(75, 75);
        button1.TabIndex = 16;
        button1.Text = ">";
        button1.UseVisualStyleBackColor = true;
        // 
        // car_deleteBtn
        // 
        car_deleteBtn.Font = new Font("Segoe UI", 12F);
        car_deleteBtn.Location = new Point(406, 280);
        car_deleteBtn.Name = "car_deleteBtn";
        car_deleteBtn.Size = new Size(100, 29);
        car_deleteBtn.TabIndex = 15;
        car_deleteBtn.Text = "Kustuta";
        car_deleteBtn.UseVisualStyleBackColor = true;
        // 
        // car_addBtn
        // 
        car_addBtn.Font = new Font("Segoe UI", 12F);
        car_addBtn.Location = new Point(279, 280);
        car_addBtn.Name = "car_addBtn";
        car_addBtn.Size = new Size(100, 29);
        car_addBtn.TabIndex = 14;
        car_addBtn.Text = "Lisa";
        car_addBtn.UseVisualStyleBackColor = true;
        car_addBtn.Click += button1_Click;
        // 
        // comboBox2
        // 
        comboBox2.Font = new Font("Segoe UI", 12F);
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new Point(300, 198);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(200, 29);
        comboBox2.TabIndex = 13;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 12F);
        label8.Location = new Point(229, 201);
        label8.Name = "label8";
        label8.Size = new Size(65, 21);
        label8.TabIndex = 12;
        label8.Text = "Omanik";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 12F);
        label7.Location = new Point(235, 155);
        label7.Name = "label7";
        label7.Size = new Size(59, 21);
        label7.TabIndex = 11;
        label7.Text = "Reg Nr";
        // 
        // car_model
        // 
        car_model.AutoSize = true;
        car_model.Font = new Font("Segoe UI", 12F);
        car_model.Location = new Point(240, 108);
        car_model.Name = "car_model";
        car_model.Size = new Size(54, 21);
        car_model.TabIndex = 10;
        car_model.Text = "Model";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 12F);
        label5.Location = new Point(215, 63);
        label5.Name = "label5";
        label5.Size = new Size(79, 21);
        label5.TabIndex = 9;
        label5.Text = "Automark";
        label5.Click += label5_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 20F);
        label4.Location = new Point(352, 3);
        label4.Name = "label4";
        label4.Size = new Size(90, 37);
        label4.TabIndex = 8;
        label4.Text = "Autod";
        // 
        // textBox3
        // 
        textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        textBox3.Location = new Point(300, 152);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(200, 29);
        textBox3.TabIndex = 6;
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        textBox1.Location = new Point(300, 105);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(200, 29);
        textBox1.TabIndex = 5;
        // 
        // car_brand
        // 
        car_brand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        car_brand.Location = new Point(300, 60);
        car_brand.Name = "car_brand";
        car_brand.Size = new Size(200, 29);
        car_brand.TabIndex = 4;
        car_brand.TextChanged += textBox2_TextChanged;
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
        // Form1
        // 
        ClientSize = new Size(800, 450);
        Controls.Add(tabControl1);
        Name = "Form1";
        Text = "Form1";
        tabControl1.ResumeLayout(false);
        ownersPage.ResumeLayout(false);
        ownersPage.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)ownersDataGridView).EndInit();
        carsPage.ResumeLayout(false);
        carsPage.PerformLayout();
        ResumeLayout(false);
    }

    private TabControl tabControl1;
    private TabPage ownersPage;
    private TabPage servicesPage;
    private DataGridView ownersDataGridView;
    private Label label1;
    private TextBox owner_fullName;
    private Label label2;
    private TextBox owner_phone;
    private Label label3;
    private Button owner_lisaBtn;
    private ComboBox comboBox1;
    private Button owner_deleteBtn;
    private PictureBox pictureBox1;
    private TextBox textBox1;
    private TextBox car_brand;
    private TextBox textBox3;
    private Label label5;
    private Label label4;
    private Label label8;
    private Label label7;
    private Label car_model;
    private ComboBox comboBox2;
    private Button car_addBtn;
    private Button car_deleteBtn;
    private Button button2;
    private Button button1;
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
    }

    private void owner_deleteBtn_Click(object sender, EventArgs e)
    {
        if (ownersDataGridView.SelectedRows.Count == 0)
        {
            MessageBox.Show("Vali rida mida tahad kustutada!");
            return;
        }

        var id = (int)ownersDataGridView.SelectedRows[0].Cells["Id"].Value;

        var owner = _db.Owners.FirstOrDefault(o => o.Id == id);
        if (owner == null)
        {
            MessageBox.Show("Omanikku ei leitud andmebaasist!");
            return;
        }

        _db.Owners.Remove(owner);
        _db.SaveChanges();

        LoadOwners();
        MessageBox.Show("Omanik kustutatud!");
    }

    private void owner_lisaBtn_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(owner_fullName.Text))
        {
            MessageBox.Show("Kirjuta õige Täisnimi!");
            return;
        }

        if (string.IsNullOrEmpty(owner_phone.Text))
        {
            MessageBox.Show("Kirjuta õige telefoninumber!");
            return;
        }

        var owner = new Owner()
        {
            FullName = owner_fullName.Text,
            Phone = owner_phone.Text
        };

        _db.Owners.Add(owner);
        _db.SaveChanges();

        LoadOwners();

        owner_fullName.Text = "";
        owner_phone.Text = "";
        MessageBox.Show("Uus omanik lisatud!");
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
}

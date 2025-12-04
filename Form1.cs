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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        tabControl1 = new TabControl();
        ownersPage = new TabPage();
        label3 = new Label();
        owners_searchTxt = new TextBox();
        pictureBox1 = new PictureBox();
        owner_deleteBtn = new Button();
        owner_lisaBtn = new Button();
        label2 = new Label();
        owner_phone = new TextBox();
        label1 = new Label();
        owner_fullName = new TextBox();
        ownersDataGridView = new DataGridView();
        carsPage = new TabPage();
        cars_ownerSearchBtn = new Button();
        imgList = new ImageList(components);
        cars_updateBtn = new Button();
        cars_firstBtn = new Button();
        cars_lastBtn = new Button();
        cars_previousBtn = new Button();
        cars_nextBtn = new Button();
        car_deleteBtn = new Button();
        car_addBtn = new Button();
        cars_owner = new ComboBox();
        label8 = new Label();
        label7 = new Label();
        car_model = new Label();
        label5 = new Label();
        label4 = new Label();
        cars_regNumber = new TextBox();
        cars_model = new TextBox();
        cars_brand = new TextBox();
        servicesPage = new TabPage();
        teenused_carSearchBtn = new Button();
        label12 = new Label();
        textBox1 = new TextBox();
        button1 = new Button();
        button2 = new Button();
        dataGridView1 = new DataGridView();
        comboBox2 = new ComboBox();
        teenused_carComboBox = new ComboBox();
        label11 = new Label();
        textBox3 = new TextBox();
        label10 = new Label();
        dateTimePicker1 = new DateTimePicker();
        label9 = new Label();
        label6 = new Label();
        tabControl1.SuspendLayout();
        ownersPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ownersDataGridView).BeginInit();
        carsPage.SuspendLayout();
        servicesPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
        tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
        // 
        // ownersPage
        // 
        ownersPage.Controls.Add(label3);
        ownersPage.Controls.Add(owners_searchTxt);
        ownersPage.Controls.Add(pictureBox1);
        ownersPage.Controls.Add(owner_deleteBtn);
        ownersPage.Controls.Add(owner_lisaBtn);
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
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F);
        label3.Location = new Point(297, 185);
        label3.Name = "label3";
        label3.Size = new Size(56, 21);
        label3.TabIndex = 12;
        label3.Text = "Otsing";
        // 
        // owners_searchTxt
        // 
        owners_searchTxt.Font = new Font("Segoe UI", 12F);
        owners_searchTxt.Location = new Point(359, 182);
        owners_searchTxt.Name = "owners_searchTxt";
        owners_searchTxt.Size = new Size(195, 29);
        owners_searchTxt.TabIndex = 11;
        owners_searchTxt.TextChanged += cars_searchTxt_TextChanged;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.owner;
        pictureBox1.Location = new Point(560, 11);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(200, 200);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 10;
        pictureBox1.TabStop = false;
        // 
        // owner_deleteBtn
        // 
        owner_deleteBtn.Font = new Font("Segoe UI", 12F);
        owner_deleteBtn.Location = new Point(114, 182);
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
        owner_lisaBtn.Location = new Point(8, 182);
        owner_lisaBtn.Name = "owner_lisaBtn";
        owner_lisaBtn.Size = new Size(100, 29);
        owner_lisaBtn.TabIndex = 8;
        owner_lisaBtn.Text = "Lisa";
        owner_lisaBtn.UseVisualStyleBackColor = true;
        owner_lisaBtn.Click += owner_lisaBtn_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        label2.Location = new Point(49, 49);
        label2.Name = "label2";
        label2.Size = new Size(59, 21);
        label2.TabIndex = 4;
        label2.Text = "Telefon";
        // 
        // owner_phone
        // 
        owner_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        owner_phone.Location = new Point(114, 46);
        owner_phone.Name = "owner_phone";
        owner_phone.Size = new Size(200, 29);
        owner_phone.TabIndex = 3;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        label1.Location = new Point(35, 14);
        label1.Name = "label1";
        label1.Size = new Size(66, 21);
        label1.TabIndex = 2;
        label1.Text = "Täisnimi";
        // 
        // owner_fullName
        // 
        owner_fullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        owner_fullName.Location = new Point(114, 11);
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
        carsPage.Controls.Add(cars_ownerSearchBtn);
        carsPage.Controls.Add(cars_updateBtn);
        carsPage.Controls.Add(cars_firstBtn);
        carsPage.Controls.Add(cars_lastBtn);
        carsPage.Controls.Add(cars_previousBtn);
        carsPage.Controls.Add(cars_nextBtn);
        carsPage.Controls.Add(car_deleteBtn);
        carsPage.Controls.Add(car_addBtn);
        carsPage.Controls.Add(cars_owner);
        carsPage.Controls.Add(label8);
        carsPage.Controls.Add(label7);
        carsPage.Controls.Add(car_model);
        carsPage.Controls.Add(label5);
        carsPage.Controls.Add(label4);
        carsPage.Controls.Add(cars_regNumber);
        carsPage.Controls.Add(cars_model);
        carsPage.Controls.Add(cars_brand);
        carsPage.Location = new Point(4, 24);
        carsPage.Name = "carsPage";
        carsPage.Padding = new Padding(3);
        carsPage.Size = new Size(792, 422);
        carsPage.TabIndex = 1;
        carsPage.Text = "Autod";
        carsPage.UseVisualStyleBackColor = true;
        // 
        // cars_ownerSearchBtn
        // 
        cars_ownerSearchBtn.Font = new Font("Segoe UI", 12F);
        cars_ownerSearchBtn.ImageKey = "search";
        cars_ownerSearchBtn.ImageList = imgList;
        cars_ownerSearchBtn.Location = new Point(506, 198);
        cars_ownerSearchBtn.Name = "cars_ownerSearchBtn";
        cars_ownerSearchBtn.Size = new Size(29, 29);
        cars_ownerSearchBtn.TabIndex = 26;
        cars_ownerSearchBtn.UseVisualStyleBackColor = true;
        cars_ownerSearchBtn.Click += cars_ownerSearchBtn_Click;
        // 
        // imgList
        // 
        imgList.ColorDepth = ColorDepth.Depth32Bit;
        imgList.ImageStream = (ImageListStreamer)resources.GetObject("imgList.ImageStream");
        imgList.TransparentColor = Color.Transparent;
        imgList.Images.SetKeyName(0, "search");
        // 
        // cars_updateBtn
        // 
        cars_updateBtn.Font = new Font("Segoe UI", 12F);
        cars_updateBtn.Location = new Point(448, 276);
        cars_updateBtn.Name = "cars_updateBtn";
        cars_updateBtn.Size = new Size(100, 29);
        cars_updateBtn.TabIndex = 20;
        cars_updateBtn.Text = "Uuenda";
        cars_updateBtn.UseVisualStyleBackColor = true;
        cars_updateBtn.Click += cars_updateBtn_Click;
        // 
        // cars_firstBtn
        // 
        cars_firstBtn.Font = new Font("Segoe UI", 24F);
        cars_firstBtn.Location = new Point(33, 230);
        cars_firstBtn.Name = "cars_firstBtn";
        cars_firstBtn.Size = new Size(75, 75);
        cars_firstBtn.TabIndex = 19;
        cars_firstBtn.Text = "<<";
        cars_firstBtn.UseVisualStyleBackColor = true;
        cars_firstBtn.Click += cars_firstBtn_Click;
        // 
        // cars_lastBtn
        // 
        cars_lastBtn.Font = new Font("Segoe UI", 24F);
        cars_lastBtn.Location = new Point(686, 230);
        cars_lastBtn.Name = "cars_lastBtn";
        cars_lastBtn.Size = new Size(75, 75);
        cars_lastBtn.TabIndex = 18;
        cars_lastBtn.Text = ">>";
        cars_lastBtn.UseVisualStyleBackColor = true;
        cars_lastBtn.Click += cars_lastBtn_Click;
        // 
        // cars_previousBtn
        // 
        cars_previousBtn.Font = new Font("Segoe UI", 24F);
        cars_previousBtn.Location = new Point(33, 147);
        cars_previousBtn.Name = "cars_previousBtn";
        cars_previousBtn.Size = new Size(75, 75);
        cars_previousBtn.TabIndex = 17;
        cars_previousBtn.Text = "<";
        cars_previousBtn.UseVisualStyleBackColor = true;
        cars_previousBtn.Click += cars_previousBtn_Click;
        // 
        // cars_nextBtn
        // 
        cars_nextBtn.Font = new Font("Segoe UI", 24F);
        cars_nextBtn.Location = new Point(686, 147);
        cars_nextBtn.Name = "cars_nextBtn";
        cars_nextBtn.Size = new Size(75, 75);
        cars_nextBtn.TabIndex = 16;
        cars_nextBtn.Text = ">";
        cars_nextBtn.UseVisualStyleBackColor = true;
        cars_nextBtn.Click += cars_nextBtn_Click;
        // 
        // car_deleteBtn
        // 
        car_deleteBtn.Font = new Font("Segoe UI", 12F);
        car_deleteBtn.Location = new Point(342, 276);
        car_deleteBtn.Name = "car_deleteBtn";
        car_deleteBtn.Size = new Size(100, 29);
        car_deleteBtn.TabIndex = 15;
        car_deleteBtn.Text = "Kustuta";
        car_deleteBtn.UseVisualStyleBackColor = true;
        car_deleteBtn.Click += car_deleteBtn_Click_1;
        // 
        // car_addBtn
        // 
        car_addBtn.Font = new Font("Segoe UI", 12F);
        car_addBtn.Location = new Point(236, 276);
        car_addBtn.Name = "car_addBtn";
        car_addBtn.Size = new Size(100, 29);
        car_addBtn.TabIndex = 14;
        car_addBtn.Text = "Lisa";
        car_addBtn.UseVisualStyleBackColor = true;
        car_addBtn.Click += car_addBtn_Click;
        // 
        // cars_owner
        // 
        cars_owner.Font = new Font("Segoe UI", 12F);
        cars_owner.FormattingEnabled = true;
        cars_owner.Location = new Point(300, 198);
        cars_owner.Name = "cars_owner";
        cars_owner.Size = new Size(200, 29);
        cars_owner.TabIndex = 13;
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
        // cars_regNumber
        // 
        cars_regNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        cars_regNumber.Location = new Point(300, 152);
        cars_regNumber.Name = "cars_regNumber";
        cars_regNumber.Size = new Size(200, 29);
        cars_regNumber.TabIndex = 6;
        // 
        // cars_model
        // 
        cars_model.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        cars_model.Location = new Point(300, 105);
        cars_model.Name = "cars_model";
        cars_model.Size = new Size(200, 29);
        cars_model.TabIndex = 5;
        // 
        // cars_brand
        // 
        cars_brand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        cars_brand.Location = new Point(300, 60);
        cars_brand.Name = "cars_brand";
        cars_brand.Size = new Size(200, 29);
        cars_brand.TabIndex = 4;
        // 
        // servicesPage
        // 
        servicesPage.Controls.Add(teenused_carSearchBtn);
        servicesPage.Controls.Add(label12);
        servicesPage.Controls.Add(textBox1);
        servicesPage.Controls.Add(button1);
        servicesPage.Controls.Add(button2);
        servicesPage.Controls.Add(dataGridView1);
        servicesPage.Controls.Add(comboBox2);
        servicesPage.Controls.Add(teenused_carComboBox);
        servicesPage.Controls.Add(label11);
        servicesPage.Controls.Add(textBox3);
        servicesPage.Controls.Add(label10);
        servicesPage.Controls.Add(dateTimePicker1);
        servicesPage.Controls.Add(label9);
        servicesPage.Controls.Add(label6);
        servicesPage.Location = new Point(4, 24);
        servicesPage.Name = "servicesPage";
        servicesPage.Size = new Size(792, 422);
        servicesPage.TabIndex = 2;
        servicesPage.Text = "Hooldus ja Teenused";
        servicesPage.UseVisualStyleBackColor = true;
        // 
        // teenused_carSearchBtn
        // 
        teenused_carSearchBtn.Font = new Font("Segoe UI", 12F);
        teenused_carSearchBtn.ImageKey = "search";
        teenused_carSearchBtn.ImageList = imgList;
        teenused_carSearchBtn.Location = new Point(343, 12);
        teenused_carSearchBtn.Name = "teenused_carSearchBtn";
        teenused_carSearchBtn.Size = new Size(30, 29);
        teenused_carSearchBtn.TabIndex = 25;
        teenused_carSearchBtn.UseVisualStyleBackColor = true;
        teenused_carSearchBtn.Click += teenused_carSearchBtn_Click;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new Font("Segoe UI", 12F);
        label12.Location = new Point(527, 170);
        label12.Name = "label12";
        label12.Size = new Size(56, 21);
        label12.TabIndex = 24;
        label12.Text = "Otsing";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 12F);
        textBox1.Location = new Point(589, 167);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(195, 29);
        textBox1.TabIndex = 23;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 12F);
        button1.Location = new Point(114, 167);
        button1.Name = "button1";
        button1.Size = new Size(100, 29);
        button1.TabIndex = 22;
        button1.Text = "Kustuta";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Font = new Font("Segoe UI", 12F);
        button2.Location = new Point(8, 167);
        button2.Name = "button2";
        button2.Size = new Size(100, 29);
        button2.TabIndex = 21;
        button2.Text = "Lisa";
        button2.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(8, 202);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(776, 212);
        dataGridView1.TabIndex = 20;
        // 
        // comboBox2
        // 
        comboBox2.Font = new Font("Segoe UI", 12F);
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new Point(114, 47);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(223, 29);
        comboBox2.TabIndex = 19;
        // 
        // teenused_carComboBox
        // 
        teenused_carComboBox.Font = new Font("Segoe UI", 12F);
        teenused_carComboBox.FormattingEnabled = true;
        teenused_carComboBox.Location = new Point(114, 12);
        teenused_carComboBox.Name = "teenused_carComboBox";
        teenused_carComboBox.Size = new Size(223, 29);
        teenused_carComboBox.TabIndex = 18;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new Font("Segoe UI", 12F);
        label11.Location = new Point(44, 120);
        label11.Name = "label11";
        label11.Size = new Size(64, 21);
        label11.TabIndex = 17;
        label11.Text = "Läbisõit";
        // 
        // textBox3
        // 
        textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
        textBox3.Location = new Point(114, 117);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(223, 29);
        textBox3.TabIndex = 16;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Segoe UI", 12F);
        label10.Location = new Point(38, 88);
        label10.Name = "label10";
        label10.Size = new Size(70, 21);
        label10.TabIndex = 15;
        label10.Text = "Kuupäev";
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Font = new Font("Segoe UI", 12F);
        dateTimePicker1.Location = new Point(114, 82);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(223, 29);
        dateTimePicker1.TabIndex = 14;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI", 12F);
        label9.Location = new Point(51, 50);
        label9.Name = "label9";
        label9.Size = new Size(57, 21);
        label9.TabIndex = 13;
        label9.Text = "Teenus";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 12F);
        label6.Location = new Point(65, 15);
        label6.Name = "label6";
        label6.Size = new Size(43, 21);
        label6.TabIndex = 11;
        label6.Text = "Auto";
        label6.Click += label6_Click;
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
        servicesPage.ResumeLayout(false);
        servicesPage.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    private Button owner_lisaBtn;
    private Button owner_deleteBtn;
    private PictureBox pictureBox1;
    private TextBox cars_model;
    private TextBox cars_brand;
    private TextBox cars_regNumber;
    private Label label5;
    private Label label4;
    private Label label8;
    private Label label7;
    private Label car_model;
    private ComboBox cars_owner;
    private Button car_addBtn;
    private Button car_deleteBtn;
    private Button cars_previousBtn;
    private Button cars_nextBtn;
    private Button cars_firstBtn;
    private Button cars_lastBtn;
    private Button cars_updateBtn;
    private Label label3;
    private TextBox owners_searchTxt;
    private Label label9;
    private Label label6;
    private Label label10;
    private DateTimePicker dateTimePicker1;
    private Label label11;
    private TextBox textBox3;
    private ComboBox teenused_carComboBox;
    private ComboBox comboBox2;
    private DataGridView dataGridView1;
    private Label label12;
    private TextBox textBox1;
    private Button button1;
    private Button button2;
    private Button teenused_carSearchBtn;
    private ImageList imgList;
    private System.ComponentModel.IContainer components;
    private Button cars_ownerSearchBtn;
    private TabPage carsPage;

    private void LoadOwners()
    {
        var filter = owners_searchTxt.Text ?? "";

        var owners = _db.Owners.Include(i => i.Cars)
            .Where(i => filter == "" || i.FullName.Contains(filter) || i.Phone.Contains(filter))
            .Select(i => new
            {
                i.Id,
                i.FullName,
                i.Phone,
                Cars = i.Cars.Count == 0 ? "None" : i.Cars.ToCommaSepString(", "),
            }).ToList();

        ownersDataGridView.DataSource = owners;
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

    private int SelectedCarIndex = 0;

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tabControl1.SelectedTab == ownersPage)
        {
            LoadOwners();
        }
        if (tabControl1.SelectedTab == carsPage)
        {
            LoadCarTab();
        }
        if (tabControl1.SelectedTab == servicesPage)
        {
            LoadTeenused();
        }
    }

    private void LoadCarTab()
    {
        var owners = _db.Owners.ToList();

        cars_owner.DataSource = owners;
        cars_owner.DisplayMember = "FullName";
        cars_owner.ValueMember = "Id";
        LoadCar();
    }

    private void LoadCar()
    {
        var cars = _db.Cars.Include(c => c.Owner).ToList();

        if (cars.Count == 0 || SelectedCarIndex < 0 || SelectedCarIndex >= cars.Count)
        {
            cars_brand.Text = "";
            cars_model.Text = "";
            cars_regNumber.Text = "";
            cars_owner.SelectedIndex = -1;
            return;
        }

        var car = cars[SelectedCarIndex];
        cars_brand.Text = car.Brand;
        cars_model.Text = car.Model;
        cars_regNumber.Text = car.RegistrationNumber;

        cars_owner.SelectedValue = car.OwnerId;
    }

    private void cars_nextBtn_Click(object sender, EventArgs e)
    {
        if (SelectedCarIndex < _db.Cars.Count())
            SelectedCarIndex++;

        LoadCar();
    }


    private void cars_previousBtn_Click(object sender, EventArgs e)
    {
        if (SelectedCarIndex > 0)
            SelectedCarIndex--;

        LoadCar();
    }


    private void cars_lastBtn_Click(object sender, EventArgs e)
    {
        if (_db.Cars.Count() == 0)
        {
            LoadCar();
            return;
        }

        SelectedCarIndex = _db.Cars.Count() - 1;
        LoadCar();
    }

    private void cars_firstBtn_Click(object sender, EventArgs e)
    {
        if (_db.Cars.Count() == 0)
        {
            LoadCar();
            return;
        }

        SelectedCarIndex = 0;
        LoadCar();
    }

    private void car_addBtn_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(cars_brand.Text))
        {
            MessageBox.Show("Kirjuta õige automark!");
            return;
        }

        if (cars_owner.SelectedIndex == -1)
        {
            MessageBox.Show("Vali omanik!");
            return;
        }

        var car = new Car()
        {
            Brand = cars_brand.Text,
            Model = cars_model.Text,
            RegistrationNumber = cars_regNumber.Text,
            OwnerId = (int)cars_owner.SelectedValue
        };

        _db.Cars.Add(car);
        _db.SaveChanges();

        SelectedCarIndex = _db.Cars.Count() - 1;

        LoadCar();

        MessageBox.Show("Auto lisatud!");
    }


    private void LoadOwnersToComboBox()
    {
        var owners = _db.Owners.ToList();

        cars_owner.DataSource = owners;
        cars_owner.DisplayMember = "FullName";
        cars_owner.ValueMember = "Id";
    }

    private void car_deleteBtn_Click_1(object sender, EventArgs e)
    {
        var cars = _db.Cars.Include(c => c.Owner).ToList();
        var car = cars.ElementAtOrDefault(SelectedCarIndex);
        if (car == null)
            return;

        _db.Cars.Remove(car);
        _db.SaveChanges();

        LoadCar();
    }

    private void cars_updateBtn_Click(object sender, EventArgs e)
    {
        var cars = _db.Cars.Include(c => c.Owner).ToList();
        var car = cars.ElementAtOrDefault(SelectedCarIndex);
        if (car == null)
            return;

        car.Brand = cars_brand.Text;
        car.Model = cars_model.Text;
        car.RegistrationNumber = cars_regNumber.Text;
        car.OwnerId = (int)cars_owner.SelectedValue;

        _db.SaveChanges();

        LoadCar();
    }

    private void cars_searchTxt_TextChanged(object sender, EventArgs e)
    {
        LoadOwners();
    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void LoadTeenused()
    {
        var cars = _db.Cars.ToList();

        teenused_carComboBox.DataSource = cars;
        teenused_carComboBox.DisplayMember = "RegistrationNumber";
        teenused_carComboBox.ValueMember = "Id";
    }

    private void teenused_carSearchBtn_Click(object sender, EventArgs e)
    {
        using (var searchForm = new CarSearchForm())
        {
            if (searchForm.ShowDialog() != DialogResult.OK)
                return;

            var chosenCar = searchForm.SelectedCar;
            if (chosenCar != null)
            {
                teenused_carComboBox.SelectedValue = chosenCar.Id;
            }
        }
    }

    private void cars_ownerSearchBtn_Click(object sender, EventArgs e)
    {
        using (var searchForm = new OwnerSearchForm())
        {
            if (searchForm.ShowDialog() != DialogResult.OK)
                return;

            var chosenOwner = searchForm.SelectedOwner;
            if (chosenOwner != null)
            {
                cars_owner.SelectedValue = chosenOwner.Id;
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1;

public partial class Autovorm : Form
{
    private readonly CarsDbContext _db;

    public Autovorm()
    {
        string lang = Properties.Settings.Default.Language;
        if (string.IsNullOrEmpty(lang)) lang = "et";
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);

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
        components = new Container();
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Autovorm));
        tabControl1 = new TabControl();
        ownersPage = new TabPage();
        owner_updateBtn = new Button();
        label13 = new Label();
        language_comboBox = new ComboBox();
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
        label14 = new Label();
        service_time = new DateTimePicker();
        teenused_carSearchBtn = new Button();
        label12 = new Label();
        services_search = new TextBox();
        service_deleteBtn = new Button();
        service_insertBtn = new Button();
        service_dataGrid = new DataGridView();
        service_serviceComboBox = new ComboBox();
        service_carComboBox = new ComboBox();
        label11 = new Label();
        service_mileage = new TextBox();
        label10 = new Label();
        service_date = new DateTimePicker();
        label9 = new Label();
        label6 = new Label();
        service_updateBtn = new Button();
        tabControl1.SuspendLayout();
        ownersPage.SuspendLayout();
        ((ISupportInitialize)pictureBox1).BeginInit();
        ((ISupportInitialize)ownersDataGridView).BeginInit();
        carsPage.SuspendLayout();
        servicesPage.SuspendLayout();
        ((ISupportInitialize)service_dataGrid).BeginInit();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(ownersPage);
        tabControl1.Controls.Add(carsPage);
        tabControl1.Controls.Add(servicesPage);
        resources.ApplyResources(tabControl1, "tabControl1");
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
        // 
        // ownersPage
        // 
        ownersPage.Controls.Add(owner_updateBtn);
        ownersPage.Controls.Add(label13);
        ownersPage.Controls.Add(language_comboBox);
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
        resources.ApplyResources(ownersPage, "ownersPage");
        ownersPage.Name = "ownersPage";
        ownersPage.UseVisualStyleBackColor = true;
        // 
        // owner_updateBtn
        // 
        resources.ApplyResources(owner_updateBtn, "owner_updateBtn");
        owner_updateBtn.Name = "owner_updateBtn";
        owner_updateBtn.UseVisualStyleBackColor = true;
        owner_updateBtn.Click += owner_updateBtn_Click;
        // 
        // label13
        // 
        resources.ApplyResources(label13, "label13");
        label13.Name = "label13";
        // 
        // language_comboBox
        // 
        resources.ApplyResources(language_comboBox, "language_comboBox");
        language_comboBox.FormattingEnabled = true;
        language_comboBox.Name = "language_comboBox";
        language_comboBox.SelectedIndexChanged += language_SelectedIndexChanged;
        // 
        // label3
        // 
        resources.ApplyResources(label3, "label3");
        label3.Name = "label3";
        // 
        // owners_searchTxt
        // 
        resources.ApplyResources(owners_searchTxt, "owners_searchTxt");
        owners_searchTxt.Name = "owners_searchTxt";
        owners_searchTxt.TextChanged += cars_searchTxt_TextChanged;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.owner;
        resources.ApplyResources(pictureBox1, "pictureBox1");
        pictureBox1.Name = "pictureBox1";
        pictureBox1.TabStop = false;
        // 
        // owner_deleteBtn
        // 
        resources.ApplyResources(owner_deleteBtn, "owner_deleteBtn");
        owner_deleteBtn.Name = "owner_deleteBtn";
        owner_deleteBtn.UseVisualStyleBackColor = true;
        owner_deleteBtn.Click += owner_deleteBtn_Click;
        // 
        // owner_lisaBtn
        // 
        resources.ApplyResources(owner_lisaBtn, "owner_lisaBtn");
        owner_lisaBtn.Name = "owner_lisaBtn";
        owner_lisaBtn.UseVisualStyleBackColor = true;
        owner_lisaBtn.Click += owner_lisaBtn_Click;
        // 
        // label2
        // 
        resources.ApplyResources(label2, "label2");
        label2.Name = "label2";
        // 
        // owner_phone
        // 
        resources.ApplyResources(owner_phone, "owner_phone");
        owner_phone.Name = "owner_phone";
        // 
        // label1
        // 
        resources.ApplyResources(label1, "label1");
        label1.Name = "label1";
        // 
        // owner_fullName
        // 
        resources.ApplyResources(owner_fullName, "owner_fullName");
        owner_fullName.Name = "owner_fullName";
        // 
        // ownersDataGridView
        // 
        ownersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        resources.ApplyResources(ownersDataGridView, "ownersDataGridView");
        ownersDataGridView.Name = "ownersDataGridView";
        ownersDataGridView.RowHeaderMouseClick += ownersDataGridView_RowHeaderMouseClick;
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
        resources.ApplyResources(carsPage, "carsPage");
        carsPage.Name = "carsPage";
        carsPage.UseVisualStyleBackColor = true;
        // 
        // cars_ownerSearchBtn
        // 
        resources.ApplyResources(cars_ownerSearchBtn, "cars_ownerSearchBtn");
        cars_ownerSearchBtn.ImageList = imgList;
        cars_ownerSearchBtn.Name = "cars_ownerSearchBtn";
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
        resources.ApplyResources(cars_updateBtn, "cars_updateBtn");
        cars_updateBtn.Name = "cars_updateBtn";
        cars_updateBtn.UseVisualStyleBackColor = true;
        cars_updateBtn.Click += cars_updateBtn_Click;
        // 
        // cars_firstBtn
        // 
        resources.ApplyResources(cars_firstBtn, "cars_firstBtn");
        cars_firstBtn.Name = "cars_firstBtn";
        cars_firstBtn.UseVisualStyleBackColor = true;
        cars_firstBtn.Click += cars_firstBtn_Click;
        // 
        // cars_lastBtn
        // 
        resources.ApplyResources(cars_lastBtn, "cars_lastBtn");
        cars_lastBtn.Name = "cars_lastBtn";
        cars_lastBtn.UseVisualStyleBackColor = true;
        cars_lastBtn.Click += cars_lastBtn_Click;
        // 
        // cars_previousBtn
        // 
        resources.ApplyResources(cars_previousBtn, "cars_previousBtn");
        cars_previousBtn.Name = "cars_previousBtn";
        cars_previousBtn.UseVisualStyleBackColor = true;
        cars_previousBtn.Click += cars_previousBtn_Click;
        // 
        // cars_nextBtn
        // 
        resources.ApplyResources(cars_nextBtn, "cars_nextBtn");
        cars_nextBtn.Name = "cars_nextBtn";
        cars_nextBtn.UseVisualStyleBackColor = true;
        cars_nextBtn.Click += cars_nextBtn_Click;
        // 
        // car_deleteBtn
        // 
        resources.ApplyResources(car_deleteBtn, "car_deleteBtn");
        car_deleteBtn.Name = "car_deleteBtn";
        car_deleteBtn.UseVisualStyleBackColor = true;
        car_deleteBtn.Click += car_deleteBtn_Click_1;
        // 
        // car_addBtn
        // 
        resources.ApplyResources(car_addBtn, "car_addBtn");
        car_addBtn.Name = "car_addBtn";
        car_addBtn.UseVisualStyleBackColor = true;
        car_addBtn.Click += car_addBtn_Click;
        // 
        // cars_owner
        // 
        resources.ApplyResources(cars_owner, "cars_owner");
        cars_owner.FormattingEnabled = true;
        cars_owner.Name = "cars_owner";
        // 
        // label8
        // 
        resources.ApplyResources(label8, "label8");
        label8.Name = "label8";
        // 
        // label7
        // 
        resources.ApplyResources(label7, "label7");
        label7.Name = "label7";
        // 
        // car_model
        // 
        resources.ApplyResources(car_model, "car_model");
        car_model.Name = "car_model";
        // 
        // label5
        // 
        resources.ApplyResources(label5, "label5");
        label5.Name = "label5";
        // 
        // label4
        // 
        resources.ApplyResources(label4, "label4");
        label4.Name = "label4";
        // 
        // cars_regNumber
        // 
        resources.ApplyResources(cars_regNumber, "cars_regNumber");
        cars_regNumber.Name = "cars_regNumber";
        // 
        // cars_model
        // 
        resources.ApplyResources(cars_model, "cars_model");
        cars_model.Name = "cars_model";
        // 
        // cars_brand
        // 
        resources.ApplyResources(cars_brand, "cars_brand");
        cars_brand.Name = "cars_brand";
        // 
        // servicesPage
        // 
        servicesPage.Controls.Add(service_updateBtn);
        servicesPage.Controls.Add(label14);
        servicesPage.Controls.Add(service_time);
        servicesPage.Controls.Add(teenused_carSearchBtn);
        servicesPage.Controls.Add(label12);
        servicesPage.Controls.Add(services_search);
        servicesPage.Controls.Add(service_deleteBtn);
        servicesPage.Controls.Add(service_insertBtn);
        servicesPage.Controls.Add(service_dataGrid);
        servicesPage.Controls.Add(service_serviceComboBox);
        servicesPage.Controls.Add(service_carComboBox);
        servicesPage.Controls.Add(label11);
        servicesPage.Controls.Add(service_mileage);
        servicesPage.Controls.Add(label10);
        servicesPage.Controls.Add(service_date);
        servicesPage.Controls.Add(label9);
        servicesPage.Controls.Add(label6);
        resources.ApplyResources(servicesPage, "servicesPage");
        servicesPage.Name = "servicesPage";
        servicesPage.UseVisualStyleBackColor = true;
        // 
        // label14
        // 
        resources.ApplyResources(label14, "label14");
        label14.Name = "label14";
        // 
        // service_time
        // 
        resources.ApplyResources(service_time, "service_time");
        service_time.Format = DateTimePickerFormat.Custom;
        service_time.Name = "service_time";
        service_time.ShowUpDown = true;
        // 
        // teenused_carSearchBtn
        // 
        resources.ApplyResources(teenused_carSearchBtn, "teenused_carSearchBtn");
        teenused_carSearchBtn.ImageList = imgList;
        teenused_carSearchBtn.Name = "teenused_carSearchBtn";
        teenused_carSearchBtn.UseVisualStyleBackColor = true;
        teenused_carSearchBtn.Click += teenused_carSearchBtn_Click;
        // 
        // label12
        // 
        resources.ApplyResources(label12, "label12");
        label12.Name = "label12";
        // 
        // services_search
        // 
        resources.ApplyResources(services_search, "services_search");
        services_search.Name = "services_search";
        services_search.TextChanged += services_search_TextChanged;
        // 
        // service_deleteBtn
        // 
        resources.ApplyResources(service_deleteBtn, "service_deleteBtn");
        service_deleteBtn.Name = "service_deleteBtn";
        service_deleteBtn.UseVisualStyleBackColor = true;
        service_deleteBtn.Click += service_deleteBtn_Click;
        // 
        // service_insertBtn
        // 
        resources.ApplyResources(service_insertBtn, "service_insertBtn");
        service_insertBtn.Name = "service_insertBtn";
        service_insertBtn.UseVisualStyleBackColor = true;
        service_insertBtn.Click += service_insertBtn_Click;
        // 
        // service_dataGrid
        // 
        service_dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        resources.ApplyResources(service_dataGrid, "service_dataGrid");
        service_dataGrid.Name = "service_dataGrid";
        service_dataGrid.RowHeaderMouseClick += service_dataGrid_RowHeaderMouseClick;
        // 
        // service_serviceComboBox
        // 
        resources.ApplyResources(service_serviceComboBox, "service_serviceComboBox");
        service_serviceComboBox.FormattingEnabled = true;
        service_serviceComboBox.Name = "service_serviceComboBox";
        // 
        // service_carComboBox
        // 
        resources.ApplyResources(service_carComboBox, "service_carComboBox");
        service_carComboBox.FormattingEnabled = true;
        service_carComboBox.Name = "service_carComboBox";
        // 
        // label11
        // 
        resources.ApplyResources(label11, "label11");
        label11.Name = "label11";
        // 
        // service_mileage
        // 
        resources.ApplyResources(service_mileage, "service_mileage");
        service_mileage.Name = "service_mileage";
        service_mileage.KeyPress += service_mileage_KeyPress;
        // 
        // label10
        // 
        resources.ApplyResources(label10, "label10");
        label10.Name = "label10";
        // 
        // service_date
        // 
        resources.ApplyResources(service_date, "service_date");
        service_date.Format = DateTimePickerFormat.Custom;
        service_date.Name = "service_date";
        // 
        // label9
        // 
        resources.ApplyResources(label9, "label9");
        label9.Name = "label9";
        // 
        // label6
        // 
        resources.ApplyResources(label6, "label6");
        label6.Name = "label6";
        label6.Click += label6_Click;
        // 
        // service_updateBtn
        // 
        resources.ApplyResources(service_updateBtn, "service_updateBtn");
        service_updateBtn.Name = "service_updateBtn";
        service_updateBtn.UseVisualStyleBackColor = true;
        service_updateBtn.Click += service_updateBtn_Click;
        // 
        // Autovorm
        // 
        resources.ApplyResources(this, "$this");
        Controls.Add(tabControl1);
        Name = "Autovorm";
        tabControl1.ResumeLayout(false);
        ownersPage.ResumeLayout(false);
        ownersPage.PerformLayout();
        ((ISupportInitialize)pictureBox1).EndInit();
        ((ISupportInitialize)ownersDataGridView).EndInit();
        carsPage.ResumeLayout(false);
        carsPage.PerformLayout();
        servicesPage.ResumeLayout(false);
        servicesPage.PerformLayout();
        ((ISupportInitialize)service_dataGrid).EndInit();
        ResumeLayout(false);
    }

    private TabControl tabControl1;
    private TabPage ownersPage;
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
    private ImageList imgList;
    private IContainer components;
    private Button cars_ownerSearchBtn;
    private Label label13;
    private ComboBox language_comboBox;
    private TabPage carsPage;
    private TabPage servicesPage;
    private Label label14;
    private DateTimePicker service_time;
    private Button teenused_carSearchBtn;
    private Label label12;
    private TextBox services_search;
    private Button service_deleteBtn;
    private Button service_insertBtn;
    private DataGridView service_dataGrid;
    private ComboBox service_serviceComboBox;
    private ComboBox service_carComboBox;
    private Label label11;
    private TextBox service_mileage;
    private Label label10;
    private DateTimePicker service_date;
    private Label label9;
    private Label label6;
    private Button owner_updateBtn;
    private Button service_updateBtn;
    private static readonly List<string> Languages = ["Eesti", "English"];

    private void LoadOwners()
    {
        var filter = owners_searchTxt.Text ?? "";

        var owners = _db.Owners.Include(i => i.Cars)
            .Where(i => filter == "" || i.FullName.Contains(filter) || i.Phone.Contains(filter))
            .Select(i => new
            {
                Owner = i,
                i.Id,
                i.FullName,
                i.Phone,
                Cars = i.Cars.Count == 0 ? "None" : i.Cars.ToCommaSepString(", "),
            }).ToList();

        ownersDataGridView.DataSource = owners;
        ownersDataGridView.Columns["Owner"].Visible = false;

        language_comboBox.DataSource = Languages;
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

        SelectedOwner = null;
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

        SelectedOwner = null;
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
        var services = _db.Services.ToList();

        service_carComboBox.DataSource = cars;
        service_carComboBox.DisplayMember = "RegistrationNumber";
        service_carComboBox.ValueMember = "Id";

        service_serviceComboBox.DataSource = services;
        service_serviceComboBox.DisplayMember = "Name";
        service_serviceComboBox.ValueMember = "Id";

        var filter = services_search.Text;
        var carServicesData = _db.CarServices.Include(i => i.Service).Include(i => i.Car).AsEnumerable()
           .Where(i => filter == "" || i.Match(filter))
           .Select(i => new
           {
               CarService = i,
               Car = i.Car,
               Service = i.Service,
               Date = i.DateOfService,
               Mileage = i.Mileage,
           }).ToList();

        service_dataGrid.DataSource = carServicesData;
        service_dataGrid.Columns["CarService"].Visible = false;
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
                service_carComboBox.SelectedValue = chosenCar.Id;
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

    private void service_insertBtn_Click(object sender, EventArgs e)
    {
        if (service_carComboBox.SelectedIndex == -1 || service_serviceComboBox.SelectedIndex == -1)
        {
            MessageBox.Show("Palun vali õige auto ja teenus!");
            return;
        }

        if (string.IsNullOrEmpty(service_mileage.Text))
        {
            MessageBox.Show("Palun sisesta läbisõit!");
            return;
        }

        var date = service_date.Value.Date;
        var time = service_time.Value;
        var dateTime = date
            .AddHours(time.Hour)
            .AddMinutes(time.Minute)
            .AddSeconds(time.Second);

        var carService = new CarService()
        {
            CarId = (service_carComboBox.SelectedItem as Car)!.Id,
            ServiceId = (service_serviceComboBox.SelectedItem as Service)!.Id,
            DateOfService = dateTime,
            Mileage = int.Parse(service_mileage.Text)
        };

        try
        {
            _db.CarServices.Add(carService);
        }
        catch
        {
            MessageBox.Show("Teenus selle andmetega on juba lisatud.");
            return;
        }

        _db.SaveChanges();

        LoadTeenused();

        MessageBox.Show("Teenus lisatud!");
    }

    private CarService? SelectedCarService;

    private void service_deleteBtn_Click(object sender, EventArgs e)
    {
        if (service_dataGrid.SelectedRows.Count == 0)
        {
            MessageBox.Show("Vali rida mida tahad kustutada!");
            return;
        }

        var carService = (CarService)service_dataGrid.SelectedRows[0].Cells["CarService"].Value;

        _db.CarServices.Remove(carService);
        _db.SaveChanges();

        LoadTeenused();

        SelectedCarService = null;
    }

    private bool _isFlashing;

    private async void service_mileage_KeyPress(object sender, KeyPressEventArgs e)
    {
        HandleNumberOnlyKeyPress(sender, e);
    }

    private async void HandleNumberOnlyKeyPress(object sender, KeyPressEventArgs e)
    {
        var textBox = sender as TextBox;
        if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            return;

        e.Handled = true;

        if (!_isFlashing)
        {
            Color original = textBox.BackColor;
            textBox.BackColor = Color.LightCoral;
            _isFlashing = true;

            await Task.Delay(150);

            textBox.BackColor = original;
            _isFlashing = false;
        }
    }

    private void language_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (language_comboBox.SelectedItem.ToString())
        {
            case "English":
                SetLanguage("en");
                break;
            case "(Default)" or "Eesti":
                SetLanguage("et");
                break;
        }

        Properties.Settings.Default.Language = Thread.CurrentThread.CurrentUICulture.Name;
        Properties.Settings.Default.Save();
    }


    private void SetLanguage(string langCode)
    {
        if (Thread.CurrentThread.CurrentUICulture.Name == langCode)
            return;

        Thread.CurrentThread.CurrentUICulture = new CultureInfo(langCode);

        ApplyResourceToControls(this, new ComponentResourceManager(this.GetType()));
    }

    private void ApplyResourceToControls(Control control, ComponentResourceManager resource)
    {
        foreach (Control c in control.Controls)
        {
            resource.ApplyResources(c, c.Name);
            if (c.HasChildren)
                ApplyResourceToControls(c, resource);
        }

        resource.ApplyResources(control, control.Name);
    }

    private void ownersDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        var row = ownersDataGridView.SelectedRows[0];
        var owner = (Owner)row.Cells["Owner"].Value;

        PutSelectedOwner(owner);
    }

    private Owner? SelectedOwner;

    private void PutSelectedOwner(Owner owner)
    {
        SelectedOwner = owner;
        owner_fullName.Text = owner.FullName;
        owner_phone.Text = owner.Phone;
    }

    private void ClearOwnerFields()
    {
        owner_fullName.Text = "";
        owner_phone.Text = "";
    }

    private void owner_updateBtn_Click(object sender, EventArgs e)
    {
        if (SelectedOwner == null)
            return;

        var fullName = owner_fullName.Text;
        var phone = owner_phone.Text;

        SelectedOwner.FullName = fullName;
        SelectedOwner.Phone = phone;
        _db.SaveChanges();

        SelectedOwner = null;
        ClearOwnerFields();
        LoadOwners();
    }

    private void service_dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        var row = service_dataGrid.SelectedRows[0];
        var carService = (CarService)row.Cells["CarService"].Value;

        PutSelectedCarService(carService);
    }

    private void services_search_TextChanged(object sender, EventArgs e)
    {
        LoadTeenused();
    }

    private void service_updateBtn_Click(object sender, EventArgs e)
    {
        if (SelectedCarService == null)
            return;

        var date = service_date.Value.Date;
        var time = service_time.Value;
        var dateTime = date
            .AddHours(time.Hour)
            .AddMinutes(time.Minute)
            .AddSeconds(time.Second);
        var carId = (service_carComboBox.SelectedItem as Car)!.Id;
        var serviceId = (service_serviceComboBox.SelectedItem as Service)!.Id;
        var mileage = int.Parse(service_mileage.Text);

        SelectedCarService.DateOfService = dateTime;
        SelectedCarService.CarId = carId;
        SelectedCarService.ServiceId = serviceId;
        SelectedCarService.Mileage = mileage;
        _db.SaveChanges();

        SelectedCarService = null;
        ClearCarServiceFields();
        LoadTeenused();
    }

    private void ClearCarServiceFields()
    {
        service_date.Value = DateTime.Now;
        service_time.Value = DateTime.Now;
        service_carComboBox.SelectedIndex = 0;
        service_serviceComboBox.SelectedIndex = 0;
        service_mileage.Text = "";
    }


    private void PutSelectedCarService(CarService carService)
    {
        SelectedCarService = carService;
        service_carComboBox.SelectedItem = carService.Car;
        service_serviceComboBox.SelectedItem = carService.Service;
        service_mileage.Text = carService.Mileage.ToString();
        service_date.Value = carService.DateOfService;
        service_time.Value = carService.DateOfService;
    }
}

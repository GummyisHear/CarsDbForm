using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1;

public partial class CarSearchForm : Form
{
    public CarSearchForm()
    {
        _db = new CarsDbContext();
        InitializeComponent();
        LoadCars();
    }

    public Car SelectedCar;

    private CarsDbContext _db;

    private void LoadCars()
    {
        var filter = searchTxt.Text ?? "";
        var cars = _db.Cars.Include(i => i.Owner)
            .Where(i => i.Brand.Contains(filter) || i.Model.Contains(filter) || 
            i.RegistrationNumber.Contains(filter) || i.Owner.FullName.Contains(filter))
            .Select(i => new
        {
            Car = i,
            Brand = i.Brand,
            Model = i.Model,
            RegNr = i.RegistrationNumber,
            Owner = $"{i.Owner.FullName} ({i.Owner.Phone})"
        }).ToList();

        dataGridView1.DataSource = cars;
        dataGridView1.Columns["Car"].Visible = false;
    }

    private void confirmBtn_Click(object sender, EventArgs e)
    {
        if (dataGridView1.CurrentRow != null)
        {
            SelectedCar = dataGridView1.CurrentRow.Cells["Car"].Value as Car;
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            MessageBox.Show("Palun vali auto.");
        }
    }

    private void searchTxt_TextChanged(object sender, EventArgs e)
    {
        LoadCars();
    }
}

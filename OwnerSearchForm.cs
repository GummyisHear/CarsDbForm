using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1;

public partial class OwnerSearchForm : Form
{
    public OwnerSearchForm()
    {
        _db = new CarsDbContext();
        InitializeComponent();
        LoadOwners();
    }

    private CarsDbContext _db;
    public Owner SelectedOwner;

    private void LoadOwners()
    {
        var filter = searchTxt.Text ?? "";
        var owners = _db.Owners.Include(i => i.Cars)
            .Where(i => filter == "" || i.FullName.Contains(filter) || i.Phone.Contains(filter))
            .Select(i => new
            {
                Owner = i,
                Id = i.Id,
                FullName = i.FullName,
                Phone = i.Phone,
                Cars = i.Cars.Count == 0 ? "None" : i.Cars.ToCommaSepString(", "),
            }).ToList();

        dataGridView1.DataSource = owners;
        dataGridView1.Columns["Owner"].Visible = false;
    }

    private void confirmBtn_Click(object sender, EventArgs e)
    {
        if (dataGridView1.CurrentRow != null)
        {
            SelectedOwner = dataGridView1.CurrentRow.Cells["Owner"].Value as Owner;
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            MessageBox.Show("Palun vali omanik.");
        }
    }

    private void searchTxt_TextChanged(object sender, EventArgs e)
    {
        LoadOwners();
    }
}

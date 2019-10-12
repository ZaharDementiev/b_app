using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Directory
{
    class Equipment
    {
        public string supplier { get; set; }
        public string producer { get; set; }
        public string equipmentType { get; set; }
        public string location { get; set; }
        public string tradingEquipment { get; set; }

        public Equipment(string supplier, string producer, string equipmentType, string location, string tradingEquipment)
        {
            this.supplier = supplier;
            this.producer = producer;
            this.equipmentType = equipmentType;
            this.location = location;
            this.tradingEquipment = tradingEquipment;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `equipment` (`suppliers`, `producer`, `equipment_type`, `location`, `trading_equipment`) " +
                "VALUES (@name, @prod, @eT, @loc, @tE);", db.GetConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = this.supplier;
            command.Parameters.Add("@prod", MySqlDbType.VarChar).Value = this.producer;
            command.Parameters.Add("@eT", MySqlDbType.VarChar).Value = this.equipmentType;
            command.Parameters.Add("@loc", MySqlDbType.VarChar).Value = this.location;
            command.Parameters.Add("@tE", MySqlDbType.VarChar).Value = this.tradingEquipment;

            db.OpenConnection();  //Открытие базы данных

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Товар добавлен");
            else
                MessageBox.Show("Товар не добавлен");

            db.CloseConnection(); //Закрытие базы данных
        }
    }
}

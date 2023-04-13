using System;
using System.Data;
using System.Data.SQLite;

namespace Hakaton_2023
{
    internal class Data_Base
    {
        static SQLiteConnection connection;
        static SQLiteCommand command_staff;
        static SQLiteCommand command_Stavka;
        static SQLiteCommand command_Group_Slipa;
        static SQLiteCommand command_write;
        static SQLiteCommand command_read_test;

        static string BD_adress = @"data_base.db";
        public static string Fio_Rab = " ";
        static double Stavka_rab = 0;
        public static long Hours_per_month = 0;
        public static long Payment_per_month = 0;
        public static long Working_hours = 0;
        static long user_teg_id = 0;
        public static string cyr_tg_id = "";
        public static string user_name = "";
        public static long working_hours = 0;
        public static string Fio_cyr = "";
        static long score_res = -1;
        public static long Age = 0;
        public static long Stg = 0;
        public static long Mesto = 0;
        public static string Foto = "";

        static public bool Connect_BD(string fileName)
        {
            try
            {
                connection = new SQLiteConnection("Data Source=" + fileName + ";Version=3; FailIfMissing=True");
                connection.Open();
                return true;

            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"Ошибка доступа к базе данных. Исключение: {ex.Message}");
                return false;
            }
        }


        static public bool Check_User(Telegram.Bot.Types.Update update)
        {
            Connect_BD(BD_adress);
            var message = update.Message;
            command_staff = connection.CreateCommand();
            command_staff.CommandText = "SELECT * FROM Staff";
            SQLiteDataAdapter adapter_check_user = new SQLiteDataAdapter(command_staff);
            DataTable user_id = new DataTable();
            adapter_check_user.Fill(user_id);

            if (message != null)
            {
                var user_tg_id = message.From.Id;
                foreach (DataRow row in user_id.Rows) 
                { 
                    if (row.Field<long>("TG Id chat") == user_tg_id)
                    {
                        user_teg_id = user_tg_id;
                        Stavka_rab = row.Field<double>("Stavka");
                        Fio_Rab = row.Field<string>("Fio");
                        Adding_Data();
                        Parse_Name();
                        return true;
                    }
                }
                
            }
            Console.WriteLine("Не успех!");
            return false;

        }

       public static void Update_Data()
        {
            Connect_BD(BD_adress);
            command_staff = connection.CreateCommand();
            command_staff.CommandText = "SELECT * FROM Staff";
            SQLiteDataAdapter adapter_check_user = new SQLiteDataAdapter(command_staff);
            DataTable user_id = new DataTable();
            adapter_check_user.Fill(user_id);
            foreach (DataRow row in user_id.Rows)
            {
                if (row.Field<long>("TG Id chat") == user_teg_id)
                {
                    Stavka_rab = row.Field<double>("Stavka");
                    Fio_Rab = row.Field<string>("Fio");
                    Adding_Data();
                }
            }
        }

        static void Adding_Data()
        {
            command_Stavka = connection.CreateCommand();
            command_Stavka.CommandText = "SELECT * FROM Stavka";
            SQLiteDataAdapter adapter_adding = new SQLiteDataAdapter(command_Stavka);
            DataTable user_data = new DataTable();
            adapter_adding.Fill(user_data);

            foreach(DataRow row in user_data.Rows)
            {
                if (row.Field<double>("Stavka") == Stavka_rab)
                {
                    Hours_per_month = row.Field<long>("Hours per month");
                    Payment_per_month = row.Field<long>("Payment per month");
                    working_hours = row.Field<long>("Working hours");
                    break;
                }
            }

            command_Group_Slipa = connection.CreateCommand();
            command_Group_Slipa.CommandText = "SELECT * FROM Curators";
            SQLiteDataAdapter adapter_slipa = new SQLiteDataAdapter(command_Group_Slipa);
            DataTable cr_slipa = new DataTable();
            adapter_slipa.Fill(cr_slipa);

            
            foreach (DataRow row in cr_slipa.Rows)
            {
                if (row.Field<long>("Chat Id works") == user_teg_id)
                {
                   cyr_tg_id = row.Field<string>("TG Id Chat");
                    Fio_cyr = row.Field<string>("FIO(Cur)");
                    Age = row.Field<long>("Age");
                    Stg = row.Field<long>("Stg");
                    Mesto = row.Field<long>("Mesto");
                    Foto = row.Field<string>("Foto");

                }
            }

            command_read_test = connection.CreateCommand();
            command_read_test.CommandText = "SELECT * FROM Test_Resoults";
            SQLiteDataAdapter adapter_test = new SQLiteDataAdapter(command_read_test);
            DataTable t_test = new DataTable();
            adapter_test.Fill(t_test);

            foreach(DataRow row in t_test.Rows)
            {
                if(user_teg_id==row.Field<long>("User id"))
                {
                    score_res = row.Field<long>("Test 1");
                    Console.WriteLine(score_res);
                    break;
                }
            }
        }

        public static void Write_BD(long score)
        {
            if (score_res == -1)
            {
                Console.WriteLine(score_res);
                Connect_BD(BD_adress);
                command_write = connection.CreateCommand();
                command_write.CommandText = $"INSERT INTO Test_Resoults (User id, Test 1) VALUES ({user_teg_id}, {score})";
            }
        }

        static void Parse_Name()
        {
            string temp_string = "";
            int t = 0;
            for(int i = 0;i<Fio_Rab.Length;i++)
            {
                if (Fio_Rab[i]==' ')
                {
                    if (t == 1)
                    {
                        user_name = temp_string;
                        break;
                    }
                    temp_string = "";
                    t++;
                }
                else
                {
                    temp_string += Fio_Rab[i];
                }
            }
            Console.WriteLine(temp_string);
        }
    }
}

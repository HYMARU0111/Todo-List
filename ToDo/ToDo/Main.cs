using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo;


namespace ToDo
{
    public partial class Main : Form
    {

        DataTable dt = new DataTable();


        public Main()
        {
            InitializeComponent();
        }


       
        private void Main_Load(object sender, EventArgs e)
        {
            GetTable();
        }

        //テーブル生成関数
        private DataTable GetTable()
        {
            dt.Columns.Add("登録", typeof(bool));
            dt.Columns.Add("日付", typeof(DateTime));
            dt.Columns.Add("やること", typeof(string));
            ItemData.DataSource = dt;

            return dt;
        }

        //「登録する」ボタンを押してデータを追加する
        private void Insert_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(false, date.Value.ToString("yyyy-MM-dd"), registered_todo.Text);
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            int rowIndex = ItemData.CurrentCell.RowIndex;
            ItemData.Rows.RemoveAt(rowIndex);
        }


        ////DataGridViewに値による表示方法の変更
        private void ItemData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //イベント行が一番最初行であるかつ、その値がtrueの場合
            if (e.ColumnIndex == 0 && (e.Value.Equals(true)))
            {
                //データをDataTableにバウンディングし、その値をCM取得
                CurrencyManager cm = (CurrencyManager)ItemData.BindingContext[ItemData.DataSource];

                //非同期実行       パラメタなしのメソッド呼び出す。
                this.BeginInvoke(new MethodInvoker(() =>
                {
                    if (e.RowIndex >= 0)
                    {
                        cm.SuspendBinding();//バインディング一時停止
                        ItemData.Rows[e.RowIndex].Visible = false;
                        cm.ResumeBinding();//バインディング再開
                    }
                    else if (e.RowIndex < 0)
                    {
                        throw new ArgumentOutOfRangeException("error");
                    }

                }));
            }
            else if (e.ColumnIndex <= 0 && (e.Value.Equals(null))) //チェックしないとき、CellFormattingを停止
            {
                return;
            }
        }


        private void date_ValueChanged_1(object sender, EventArgs e)
        {
            DateTimePicker dtpicker = sender as DateTimePicker;
            string sFormat = string.Empty;
            sFormat = string.Format(dtpicker.Value.ToString("yyyy-MM-dd"));
        }

        //保存ボタンを押して、テキストファイルにタスクを保存する
        private void SaveButton_Click(object sender, EventArgs e)
        {

            TextWriter writer = new StreamWriter(@"C:\Users\Public\Documents\table.txt");

            for (int i = 0; i < ItemData.Rows.Count - 1; i++)
            {
                for (int j = 0; j < ItemData.Columns.Count; j++)
                {
                    if (j == ItemData.Columns.Count - 1)
                    {
                        writer.Write("\t"+ItemData.Rows[i].Cells[j].Value.ToString());
                    }
                    else
                    {
                        writer.Write("\t"+ItemData.Rows[i].Cells[j].Value.ToString() + "\t"+"|");
                    }
                }
                writer.WriteLine("");

            }
            writer.Close();
            MessageBox.Show("データを保存しました。");
        }

        //「読み込む」ボタンをオスと保存しているタスク(.txt)ファイルを読み込む
        private void LoadButton_Click(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(@"C:\Users\Public\Documents\table.txt");
            string[] datas;


            for (int i = 0; i < lines.Length; i++)
            {
                datas = lines[i].ToString().Split('|');
                string[] row = new string[datas.Length];

                for (int j = 0; j < datas.Length; j++)
                {
                    row[j] = datas[j].Trim();
                }
                dt.Rows.Add(row);
            }
        }

        //今日を基準に過去のデータのセル色を赤に変更する
        private void ItemData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var ExpiryDate = Convert.ToDateTime(ItemData.Rows[e.RowIndex].Cells["日付"].Value);
            var Today = DateTime.Today;
            var Expired = ExpiryDate < Today;
            if (Expired)
            {
                ItemData.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}

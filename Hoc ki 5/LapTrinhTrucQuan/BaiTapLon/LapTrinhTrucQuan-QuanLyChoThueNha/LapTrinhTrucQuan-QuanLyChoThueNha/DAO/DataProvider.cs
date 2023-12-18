using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class DataProvider
    {
        // Tạo liên kết với cơ sở dữ liệu để truy xuất dữ liệu.
        //string sqlConnect = "Data Source=(local);Initial Catalog=QLChoThueNha_BTL;Persist Security Info=True;User ID=sa;Password=nam123;Trust Server Certificate=True";

        string sqlConnect = "Data Source=DESKTOP-OE5VPO5\\SQLEXPRESS;Initial Catalog=QLChoThueNha_BTL;User ID=sa;Password=nam123;";

        // Phương thức thực hiện câu lệnh SQL và trả về kết quả dưới dạng DataTable.
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            // Khởi tạo đối tượng DataTable để lưu trữ kết quả dữ liệu.
            DataTable data = new DataTable();

            // Sử dụng câu lệnh 'using' để tạo và quản lý đối tượng SqlConnection.
            using (SqlConnection connection = new SqlConnection())
            {
                // (Chưa thấy phần gán chuỗi kết nối, giả sử 'sqlConnect' là một trường hoặc thuộc tính trong lớp.)
                connection.ConnectionString = sqlConnect;

                // Mở kết nối.
                connection.Open();

                // Tạo đối tượng SqlCommand với câu lệnh SQL và kết nối đã mở.
                SqlCommand command = new SqlCommand(query, connection);

                // Nếu có tham số được cung cấp (parameter không null),
                // phương thức này sẽ phân tích câu lệnh SQL để xác định các tham số
                // (các tham số bắt đầu bằng '@') và thêm giá trị tương ứng từ mảng parameter.
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            // Thêm giá trị của tham số từ mảng parameter.
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và lưu kết quả vào đối tượng DataTable.
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                // Đóng kết nối.
                connection.Close();
            }

            // Trả về đối tượng DataTable chứa kết quả dữ liệu.
            return data;
        }


        // Hàm thực hiện câu lệnh SQL mà không trả về kết quả (ví dụ: INSERT, UPDATE, DELETE).
        // Kết quả trả về là số dòng bị ảnh hưởng bởi câu lệnh SQL.
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            // Khởi tạo biến data với giá trị mặc định là 0.
            int data = 0;

            // Sử dụng câu lệnh 'using' để tạo và quản lý đối tượng SqlConnection.
            using (SqlConnection connection = new SqlConnection())
            {
                // (Chưa thấy phần gán chuỗi kết nối, giả sử 'sqlConnect' là một trường hoặc thuộc tính trong lớp.)
                connection.ConnectionString = sqlConnect;

                // Mở kết nối.
                connection.Open();

                // Tạo đối tượng SqlCommand với câu lệnh SQL và kết nối đã mở.
                SqlCommand command = new SqlCommand(query, connection);

                // Nếu có tham số được cung cấp (parameter không null),
                // phương thức này sẽ phân tích câu lệnh SQL để xác định các tham số
                // (các tham số bắt đầu bằng '@') và thêm giá trị tương ứng từ mảng parameter.
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            // Thêm giá trị của tham số từ mảng parameter.
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                // Gọi phương thức ExecuteNonQuery trên đối tượng SqlCommand và lưu kết quả vào biến data.
                data = command.ExecuteNonQuery();

                // Đóng kết nối.
                connection.Close();
            }

            // Trả về giá trị của biến data, chứa số dòng bị ảnh hưởng bởi câu lệnh SQL.
            return data;
        }


        // Phương thức này thực hiện việc thực thi một câu lệnh SQL và trả về một giá trị scalar.
        // Giá trị scalar thường là kết quả của một câu lệnh SELECT trả về một giá trị duy nhất, như COUNT hoặc SUM.
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            // Khởi tạo biến data với giá trị mặc định là 0.
            object data = 0;

            // Sử dụng câu lệnh 'using' để tạo và quản lý đối tượng SqlConnection.
            using (SqlConnection connection = new SqlConnection())
            {
                // (Chưa thấy phần gán chuỗi kết nối, giả sử 'sqlConnect' là một trường hoặc thuộc tính trong lớp.)
                connection.ConnectionString = sqlConnect;

                // Mở kết nối.
                connection.Open();

                // Tạo đối tượng SqlCommand với câu lệnh SQL và kết nối đã mở.
                SqlCommand command = new SqlCommand(query, connection);

                // Nếu có tham số được cung cấp (parameter không null),
                // phương thức này sẽ phân tích câu lệnh SQL để xác định các tham số
                // (các tham số bắt đầu bằng '@') và thêm giá trị tương ứng từ mảng parameter.
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            // Thêm giá trị của tham số từ mảng parameter.
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                // Gọi phương thức ExecuteScalar trên đối tượng SqlCommand và lưu kết quả vào biến data.
                data = command.ExecuteScalar();

                // Đóng kết nối.
                connection.Close();
            }

            // Trả về giá trị của biến data, chứa kết quả của phương thức ExecuteScalar.
            return data;
        }

    }
}

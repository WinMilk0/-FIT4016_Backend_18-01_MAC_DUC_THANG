using SchoolManagement.Services;
using SchoolManagement.Models;

namespace SchoolManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- School Management System ---");
            
            // Khởi tạo Manager
            var manager = new StudentManager();
            
            // Chạy thử hàm hiển thị danh sách (Read)
            manager.DisplayAll(1);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

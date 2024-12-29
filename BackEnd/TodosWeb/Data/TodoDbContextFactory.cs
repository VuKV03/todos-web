using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TodosWeb.Data
{
    public class TodoDbContextFactory : IDesignTimeDbContextFactory<TodosDbContext>
    {
        public TodosDbContext CreateDbContext(string[] args)
        {
           // Đọc cấu hình từ file appsettings.json
           IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Lấy chuỗi kết nối, nó sẽ tìm kiếm thư mục có tên "TodosDatabase"
            var connectionString = configurationRoot.GetConnectionString("TodosDatabase");

            // Cấu hình DbContextOptions
            var optionBuilder = new DbContextOptionsBuilder<TodosDbContext>();
            optionBuilder.UseSqlServer(connectionString); ;

            return new TodosDbContext(optionBuilder.Options);

            // Lệnh cài: https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=vs
            // add-migration init-todos
            // Migrations: nơi lưu trữ các file migration, giúp quản lý lịch sử các thay đổi về cấu trúc db (schema) của dự án
            // Nói dễ hiểu là nhật ký ghi lại từng thay đổi đã thực hiện trên db

            // create db and schema
            // update-database
        }
    }
}

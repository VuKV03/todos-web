using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodosWeb.Models;

namespace TodosWeb.Configuration
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            // Thực thể Todo sẽ được ánh xạ vào bảng có tên là "todos" trong db
            builder.ToTable("todos");

            // Chỉ định Id là khóa chính
            builder.HasKey(t => t.Id);

            // Cấu hình thuộc tính, .IsRequired() bắt buộc phải có giá trị
            builder.Property(t => t.Name).IsRequired();

            // Nếu không giá trị thuộc tính này mặc định = false
            builder.Property(t => t.IsComplete).IsRequired().HasDefaultValue(false);
        }
    }
}

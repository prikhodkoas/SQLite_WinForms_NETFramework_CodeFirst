## 1. ��������� ����� NuGet ��������� ����

+ Microsoft.EntityFrameworkCore.Sqlite.Design
+ Microsoft.EntityFrameworkCore.Tools  (v 1.1.6)

## 2. ������ �������� � ������ �������

+ ������ ����� Entities
+ � ���� ����� ������ ������ ������ Shift
    ```
    public class Shift
    {
        public int Id { get; set; }

        public int Number { get; set; }

        [InverseProperty("Shift")]
        public virtual ICollection<CashVoucher> CashVouchers { get; set; }
    }
    ```
+ � ���� ����� ������ ������ ������ CashVoucher
    ```
    public class CashVoucher
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public int? ShiftId { get; set; }

        [InverseProperty("CashVouchers")]
        public virtual Shift Shift { get; set; }
    }
    ```
+ � ���� ����� ������ ����� ��������� TestContext.cs
+ ���������� ���� ����� �� DbContext (using Microsoft.EntityFrameworkCore;)
    ```
    public class TestContext : DbContext
    {
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<CashVoucher> CashVouchers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=TestDb.sqlite");
        }
    }
    ```
## 3. ������ ������ ��������
+ ������ ������� ���������� �������
+ �������� �������

    ```
    Add-Migration -Name "InitialMigration" -Context "TestContext"
    ```
    
    > ���� ��������� ������
    > 
    > ....cannot be loaded because running scripts is disabled on this system
    > 
    > ����� ��������� ������� �������
    > 
    > ``` Set-ExecutionPolicy RemoteSigned ```

## 4. ������ ��
+ ������ ������� ���������� �������
+ �������� �������

    ```
    Update-Database -Context "TestContext"
    ```

## 5. ������� �� ����� ���� ��������� ��� ���������� ������ � ��
+ ������� � ������ �������� [DisplayName] ��� ���� ��� ��, ��� ������������ � ��������� ���������, ������������ ���������� ����� �����
+ ������� ������� ������ �� ������� ������ ����������
+ �� ������� ������ �������� ��� ����, ������� �������� ���� ����� (� ������� Include, ������� ������� � ������ JOIN, ������� � ���� ������ ������� ����� � ������� �����)
    ```
    var cashVouchers = context.CashVouchers.Include(shift => shift.Shift).ToList();
    ```



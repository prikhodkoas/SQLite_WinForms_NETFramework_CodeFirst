# SQLite_WinForms_NETFramework_CodeFirst
SQLite Framework CodeFirst Создание, миграции, добавление, получение

## 1. Установил через NuGet следующие либы

+ Microsoft.EntityFrameworkCore.Sqlite.Design
+ Microsoft.EntityFrameworkCore.Tools  (v 1.1.6)

## 2. Создал контекст и классы моделей

+ Создал папку Entities
+ В этой папке создал класса модели Shift
    ```
    public class Shift
    {
        public int Id { get; set; }

        public int Number { get; set; }

        [InverseProperty("Shift")]
        public virtual ICollection<CashVoucher> CashVouchers { get; set; }
    }
    ```
+ В этой папке создал класса модели CashVoucher
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
+ В этой папке создал класс контекста TestContext.cs
+ Наследовал этот класс от DbContext (using Microsoft.EntityFrameworkCore;)
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
## 3. Создал первую миграцию
+ Открыл консоль диспетчерв пакетов
+ выполнил команду

    ```
    Add-Migration -Name "InitialMigration" -Context "TestContext"
    ```
    
    > Если возникает ошибка
    > 
    > ....cannot be loaded because running scripts is disabled on this system
    > 
    > Нужно выполнить сначала команду
    > 
    > ``` Set-ExecutionPolicy RemoteSigned ```

## 4. Создал БД
+ Открыл консоль диспетчерв пакетов
+ выполнил команду

    ```
    Update-Database -Context "TestContext"
    ```

## 5. Добавил на форму пару контролов для добавления данных в БД
+ Добавил в модели атрибуты [DisplayName] для того что бы, при автобиндинге и генерации контролов, отображались корректные имена полей
+ Накидал немного логики на нажатие кнопок добавления
+ На нажатие кнопки получить все чеки, добавил загрузку всех чеков (с методом Include, который добавит в запрос JOIN, который в свою очердь добавит смены в объекты чеков)
    ```
    var cashVouchers = context.CashVouchers.Include(shift => shift.Shift).ToList();
    ```


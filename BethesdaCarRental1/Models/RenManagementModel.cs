namespace BethesdaCarRental5.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations;

    public class RenManagementModel : DbContext
    {
        // Your context has been configured to use a 'RenManagementModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BethesdaCarRental5.Models.RenManagementModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RenManagementModel' 
        // connection string in the application configuration file.
        public RenManagementModel()
            : base("name=RenManagementModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<RentalOrder> RentalOrders { get; set; }

    }

    public class Employee
    {
        [Display(Name = "Employee Id")]
        public int EmployeeId { get; set; }
        [Display(Name = "Employee #")]
        public string EmployeeNumber { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Employment Title")]
        public string EmploymentTitle { get; set; }
    }

    public class Car
    {
        [Display(Name = "Car Id")]
        public int CarId { get; set; }
        [Display(Name = "Tag #")]
        public string TagNumber { get; set; }
        public string Category { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Passengers { get; set; }
        public string Condition { get; set; }
        [Display(Name = "Availability Status")]
        public string AvailabilityStatus { get; set; }
    }

    public class RentalOrder
    {
        [Display(Name = "Rental Order Id")]
        public int RentalOrderId { get; set; }
        [Display(Name = "Processed By")]
        public string RentStartProcessedBy { get; set; } // EmployeeNumber
        [Display(Name = "Employee #")]
        public string RentReturnProcessedBy { get; set; } // EmployeeNumber
        [Display(Name = "Drv. Lic. #")]
        public string DriversLicenseNumber { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        [Display(Name = "ZIP Code")]
        public string ZIPCode { get; set; }
        [Display(Name = "Car Rented")]
        public string TagNumber { get; set; }
        [Display(Name = "Car Condition")]
        public string CarCondition { get; set; }
        [Display(Name = "Tank Level")]
        public string TankLevel { get; set; }
        [Display(Name = "Mileage Start")]
        public int MileageStart { get; set; }
        [Display(Name = "Mileage End")]
        public int MileageEnd { get; set; }
        [Display(Name = "Total Mileage")]
        public int MileageTotal { get; set; }
        [Display(Name = "Start Date")]
        public string StartDate { get; set; }
        [Display(Name = "End Date")]
        public string EndDate { get; set; }
        [Display(Name = "Total Days")]
        public int TotalDays { get; set; }
        [Display(Name = "Rate Applied")]
        public decimal RateApplied { get; set; }
        [Display(Name = "Sub-Total")]
        public decimal SubTotal { get; set; }
        [Display(Name = "Tax Rate")]
        public decimal TaxRate { get; set; }
        [Display(Name = "Tax Amount")]
        public decimal TaxAmount { get; set; }
        [Display(Name = "Order Total")]
        public decimal OrderTotal { get; set; }
        [Display(Name = "Payment Date")]
        public string PaymentDate { get; set; }
        [Display(Name = "Order Status")]
        public string OrderStatus { get; set; }
    }
}
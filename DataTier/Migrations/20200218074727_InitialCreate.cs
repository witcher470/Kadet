using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataTier.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<int>(nullable: false),
                    CardCost = table.Column<int>(nullable: false),
                    ClientFristName = table.Column<string>(nullable: false),
                    ClientSecondName = table.Column<string>(nullable: false),
                    ClientThirdName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    CarModel = table.Column<string>(nullable: false),
                    StateNumber = table.Column<string>(nullable: false),
                    Region = table.Column<string>(nullable: false),
                    Duration = table.Column<DateTime>(nullable: false),
                    VIN = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Services = table.Column<int>(nullable: false),
                    SellerFirstName = table.Column<string>(nullable: false),
                    SellerSecondName = table.Column<string>(nullable: false),
                    SellerThirdName = table.Column<string>(nullable: false),
                    NumberOfContractWithKadet = table.Column<int>(nullable: false),
                    DateOfContractWithKadet = table.Column<DateTime>(nullable: false),
                    NumberOfContractWithClient = table.Column<int>(nullable: false),
                    DateOfContractWithClient = table.Column<DateTime>(nullable: false),
                    ActionStartDate = table.Column<DateTime>(nullable: false),
                    ManagerFirstName = table.Column<string>(nullable: false),
                    ManagerSecondName = table.Column<string>(nullable: false),
                    ManagerThirdName = table.Column<string>(nullable: false),
                    CardStatus = table.Column<int>(nullable: false),
                    DeactivationDate = table.Column<DateTime>(nullable: false),
                    CardAppeal = table.Column<string>(nullable: true),
                    EmployerFirstName = table.Column<string>(nullable: false),
                    EmployerSecondName = table.Column<string>(nullable: false),
                    EmployerThirdName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contractors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    SecondName = table.Column<string>(nullable: false),
                    ThirdName = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    ContractorStatus = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Services = table.Column<int>(nullable: false),
                    Cities = table.Column<string>(nullable: true),
                    PriceList = table.Column<string>(nullable: false),
                    PaymentMethod = table.Column<int>(nullable: false),
                    AnotherPhoneNumber = table.Column<string>(nullable: true),
                    WorkTime = table.Column<string>(nullable: true),
                    NumberOfTrucks = table.Column<int>(nullable: false),
                    CarryingCapacityOfTrucks = table.Column<int>(nullable: false),
                    PlatformLenght = table.Column<int>(nullable: false),
                    YearOfManufactureOfTrucks = table.Column<string>(nullable: true),
                    TrolleysStatus = table.Column<int>(nullable: false),
                    CraneManipulatorStatus = table.Column<int>(nullable: false),
                    AnotherServices = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DealerCenters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    HasFillial = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    CarBrands = table.Column<string>(nullable: true),
                    DealerCenterStatus = table.Column<int>(nullable: false),
                    Website = table.Column<string>(nullable: true),
                    ReceptionPhoneNumber = table.Column<string>(nullable: false),
                    WorkingHours = table.Column<DateTime>(nullable: false),
                    BillingInformation = table.Column<string>(nullable: true),
                    LegalPesonName = table.Column<string>(nullable: false),
                    LegalPesonBillingInformation = table.Column<string>(nullable: true),
                    LegalPesonDirectorOrSignatory = table.Column<string>(nullable: true),
                    DateTimeOfContract = table.Column<DateTime>(nullable: false),
                    SettlementPeriod = table.Column<int>(nullable: false),
                    SettlementType = table.Column<int>(nullable: false),
                    CommercialResponsiblePersonsName = table.Column<string>(nullable: true),
                    CommercialResponsiblePersonsPhoneNumber = table.Column<string>(nullable: true),
                    CommercialResponsiblePersonsEmail = table.Column<string>(nullable: true),
                    AccountingResponsiblePersonsName = table.Column<string>(nullable: true),
                    AccountingResponsiblePersonsPhoneNumber = table.Column<string>(nullable: true),
                    AccountingResponsiblePersonsEmail = table.Column<string>(nullable: true),
                    TechnicalAssistanceCardSeries = table.Column<string>(nullable: true),
                    TypesAndFillingOfServicePackages = table.Column<string>(nullable: true),
                    MaterialsLink = table.Column<string>(nullable: true),
                    Anotherproducts = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CooperatorName = table.Column<string>(nullable: true),
                    CooperatorPhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealerCenters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimeOrdered = table.Column<DateTime>(nullable: false),
                    ClientFirstName = table.Column<int>(nullable: false),
                    ClientSecondName = table.Column<int>(nullable: false),
                    ClientThirdName = table.Column<int>(nullable: false),
                    TechnicalAssistanceCardNumber = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    PointOfDeparture = table.Column<string>(nullable: true),
                    PointOfDestination = table.Column<string>(nullable: true),
                    Services = table.Column<int>(nullable: false),
                    ServicesCostForClient = table.Column<int>(nullable: false),
                    ServicesCostForContractor = table.Column<int>(nullable: false),
                    CompanyComission = table.Column<int>(nullable: false),
                    ContractorSerialNumber = table.Column<string>(nullable: false),
                    ContractorPhoneNumber = table.Column<string>(nullable: false),
                    ServiceTime = table.Column<DateTime>(nullable: false),
                    OrderStatus = table.Column<int>(nullable: false),
                    PaymentMethod = table.Column<int>(nullable: false),
                    ServiceRating = table.Column<int>(nullable: false),
                    OperatorComment = table.Column<string>(nullable: true),
                    ClientReview = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    SecondName = table.Column<string>(nullable: false),
                    ThirdName = table.Column<string>(nullable: false),
                    Role = table.Column<int>(nullable: false),
                    StartWorkDate = table.Column<DateTime>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    MainLanguage = table.Column<string>(nullable: false),
                    AnotherLanguage = table.Column<string>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserStatus = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Timezone = table.Column<string>(nullable: true),
                    PhoneSIPNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fillials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    DealercenterId = table.Column<int>(nullable: true),
                    CarBrands = table.Column<string>(nullable: true),
                    FillialStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fillials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fillials_DealerCenters_DealercenterId",
                        column: x => x.DealercenterId,
                        principalTable: "DealerCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceStations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    DealerCenterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceStations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceStations_DealerCenters_DealerCenterId",
                        column: x => x.DealerCenterId,
                        principalTable: "DealerCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fillials_DealercenterId",
                table: "Fillials",
                column: "DealercenterId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceStations_DealerCenterId",
                table: "ServiceStations",
                column: "DealerCenterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Contractors");

            migrationBuilder.DropTable(
                name: "Fillials");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ServiceStations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DealerCenters");
        }
    }
}

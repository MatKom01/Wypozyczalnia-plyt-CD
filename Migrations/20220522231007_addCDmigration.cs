using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektMVC.Migrations
{
    public partial class addCDmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CDs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Lenght = table.Column<int>(type: "int", nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scenario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Production = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Premiere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDs", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture"},
                values: new object[] { 101, "Avengers: Wojna bez granic", 29.99, 159, "Anthony Russo / Joe Russo", "Christopher Markus / Stephen McFeely", "Akcja", "USA", "23 kwietnia 2018 (świat)", "https://fwcdn.pl/fpo/37/58/693758/7839647.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 102, "Spider-Man Uniwersum", 29.99, 117, "Bob Persichetti / Peter Ramsey / więcej...", "Phil Lord / Rodney Rothman", "Akcja", "USA", "7 grudnia 2018 (świat)", "https://fwcdn.pl/fpo/32/33/743233/7866074.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 103, "Mroczny Rycerz", 29.99, 152, "Christopher Nolan", "Christopher Nolan / Jonathan Nolan", "Akcja", "USA / Wielka Brytania", "14 lipca 2008 (świat)", "https://fwcdn.pl/fpo/63/51/236351/7198307.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 104, "Iron Man", 29.99, 126, "Jon Favreau", "Hawk Ostby / Mark Fergus / więcej...", "Akcja", "USA", "14 kwietnia 2008 (świat)", "https://fwcdn.pl/fpo/25/41/122541/7885686.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 201, "Nietykalni", 29.99, 112, "Olivier Nakache / Éric Toledano", "Olivier Nakache / Éric Toledano", "Komedia", "Francja", "23 września 2011 (świat)", "https://fwcdn.pl/fpo/33/90/583390/7441162.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 202, "Forrest Gump", 29.99, 152, "Robert Zemeckis", "Eric Roth", "Komedia", "USA", "23 czerwca 1994 (świat)", "https://fwcdn.pl/fpo/09/98/998/7314731.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 203, "Życie jest piękne", 29.99, 116, "Roberto Benigni", "Roberto Benigni / Vincenzo Cerami", "Komedia", "Włochy", "20 grudnia 1997 (świat)", "https://fwcdn.pl/fpo/02/08/208/7520031.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 204, "Green Book", 29.99, 130, "Peter Farrelly", "Brian Hayes Currie / Peter Farrelly / więcej...", "Komedia", "USA", "11 września 2018 (świat)", "https://fwcdn.pl/fpo/96/30/809630/7873350.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 301, "Skazani na Shawshank", 29.99, 152, "Frank Darabont", "Frank Darabont", "Dramat", "USA", "10 września 1994 (świat)", "https://fwcdn.pl/fpo/10/48/1048/6925401.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 302, "Ojciec chrzestny", 29.99, 175, "Francis Ford Coppola", "Mario Puzo / Francis Ford Coppola", "Dramat", "USA", "15 marca 1972 (świat)", "https://fwcdn.pl/fpo/10/89/1089/7196615.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 303, "Zielona mila", 29.99, 188, "Frank Darabont", "Frank Darabont", "Dramat", "USA", "6 grudnia 1999 (świat)", "https://fwcdn.pl/fpo/08/62/862/7517878.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 304, "Lista Schindlera", 29.99, 195, "Steven Spielberg", "Steven Zaillian", "Dramat", "USA", "30 listopada 1993 (świat)", "https://fwcdn.pl/fpo/12/11/1211/7876866.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 401, "Joker", 29.99, 122, "Todd Phillips", "Todd Phillips / Scott Silver", "Kryminał", "Kanada / USA", "31 sierpnia 2019 (świat)", "https://fwcdn.pl/fpo/01/67/810167/7905225.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 402, "Siedem", 29.99, 127, "David Fincher", "Andrew Kevin Walker", "Kryminał", "USA", "15 września 1995 (świat)", "https://fwcdn.pl/fpo/07/02/702/6967799.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 403, "Leon zawodowiec", 29.99, 110, "Luc Besson", "Luc Besson", "Kryminał", "Francja / USA", "14 września 1994 (świat)", "https://fwcdn.pl/fpo/06/71/671/7016965.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 404, "Infiltracja", 29.99, 152, "Martin Scorsese", "William Monahan / Felix Chong / więcej...", "Kryminał", "Hongkong / USA", "26 września 2006 (świat)", "https://fwcdn.pl/fpo/60/05/136005/7518097.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 501, "Obcy - 8. pasażer \"Nostromo\" ", 29.99, 117, "Ridley Scott", "Dan O'Bannon", "Horror", "USA / Wielka Brytania", "25 maja 1979 (świat)", "https://fwcdn.pl/fpo/09/80/980/7518072.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 502, "Palacz zwłok", 29.99, 95, "Juraj Herz", "Juraj Herz / Ladislav Fuks / więcej...", "Horror", "Czechosłowacja", "14 marca 1969 (świat)", "https://fwcdn.pl/fpo/62/96/106296/7393235.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 503, "Lśnienie", 29.99, 156, "Stanley Kubrick", "Stanley Kubrick / Diane Johnson", "Horror", "USA / Wielka Brytania", "23 maja 1980 (świat)", "https://fwcdn.pl/fpo/10/20/1020/7183753.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 504, "Wywiad z wampirem", 29.99, 123, "Neil Jordan", "Anne Rice", "Horror", "USA", "9 listopada 1994 (świat)", "https://fwcdn.pl/fpo/10/02/1002/7314657.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 601, "Władca Pierścieni: Powrót króla", 29.99, 201, "Peter Jackson", "Fran Walsh / Peter Jackson / więcej...", "Przygoda", "Nowa Zelandia / USA", "1 grudnia 2003 (świat)", "https://fwcdn.pl/fpo/18/41/11841/7494142.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 602, "Władca Pierścieni: Dwie wieże", 29.99, 179, "Peter Jackson", "Peter Jackson / Fran Walsh / więcej...", "Przygoda", "Nowa Zelandia / USA", "5 grudnia 2002 (świat)", "https://fwcdn.pl/fpo/14/51/31451/7877022.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 603, "Gwiezdne wojny: Część V - Imperium kontratakuje", 29.99, 124, "Irvin Kershner", "Lawrence Kasdan / Leigh Brackett", "Przygoda", "USA", "17 maja 1980 (świat)", "https://fwcdn.pl/fpo/05/25/525/7371374.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 604, "Dersu Uzała", 29.99, 144, "Akira Kurosawa", "Akira Kurosawa / Yuriy Nagibin", "Przygoda", "Japonia / ZSRR", "lipiec 1975 (świat)", "https://fwcdn.pl/fpo/40/74/34074/7251334.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 701, "Nazywam się Khan", 29.99, 165, "Karan Johar", "Shibani Bathija", "Romans", "Indie / USA / Zjednoczone Emiraty Arabskie", "11 lutego 2010 (świat)", "https://fwcdn.pl/fpo/25/44/462544/7313950.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 702, "Życie jest cudem", 29.99, 154, "Emir Kusturica", "Ranko Bozic / Gordan Mihić / więcej...", "Romans", "Francja / Włochy / Serbia i Czarnogóra", "14 maja 2004 (świat)", "https://fwcdn.pl/fpo/47/51/34751/6950312.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 703, "Trzej idioci", 29.99, 170, "Rajkumar Hirani", "Vidhu Vinod Chopra / Rajkumar Hirani / więcej...", "Romans", "Indie", "23 grudnia 2009 (świat)", "https://fwcdn.pl/fpo/19/47/471947/7306663.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 704, "Jak w niebie", 29.99, 132, "Kay Pollak", "Kay Pollak / Carin Pollak / więcej...", "Romans", "Szwecja", "3 września 2004 (świat)", "https://fwcdn.pl/fpo/60/02/146002/7029130.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 801, "Podziemny krąg", 29.99, 139, "David Fincher", "Jim Uhls", "Thriller", "Niemcy / USA", "10 września 1999 (świat)", "https://fwcdn.pl/fpo/08/37/837/7522091.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 802, "Incepcja", 29.99, 148, "Christopher Nolan", "Christopher Nolan", "Thriller", "USA / Wielka Brytania", "8 lipca 2010 (świat)", "https://fwcdn.pl/fpo/08/91/500891/7354571.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 803, "Milczenie owiec", 29.99, 118, "Jonathan Demme", "Ted Tally", "Thriller", "USA", "30 stycznia 1991 (świat)", "https://fwcdn.pl/fpo/10/47/1047/7714177.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 804, "Wyspa tajemnic", 29.99, 138, "Martin Scorsese", "Laeta Kalogridis", "Thriller", "USA", "13 lutego 2010 (świat)", "https://fwcdn.pl/fpo/42/56/464256/7317256.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 901, "Coco", 29.99, 105, "Lee Unkrich / Adrian Molina", "Adrian Molina / Matthew Aldrich", "Familijny", "USA", "20 października 2017 (świat)", "https://fwcdn.pl/fpo/22/60/752260/7813486.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 902, "Król Lew", 29.99, 89, "Rob Minkoff / Roger Allers", "Jonathan Roberts / Linda Woolverton / więcej...", "Familijny", "USA", "12 czerwca 1994 (świat)", "https://fwcdn.pl/fpo/68/78/6878/7389475.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 903, "Sekrety morza", 29.99, 93, "Tomm Moore", "Will Collins", "Familijny", "Belgia / Dania / Francja / Irlandia / Luksemburg", "6 września 2014 (świat)", "https://fwcdn.pl/fpo/24/76/622476/7695132.6.jpg" });

            migrationBuilder.InsertData(
                table: "CDs",
                columns: new[] { "ID", "Title", "Price", "Lenght", "Direction", "Scenario", "Type", "Production", "Premiere", "Picture" },
                values: new object[] { 904, "Jak wytresować smoka", 29.99, 98, "Dean DeBlois / Chris Sanders", "Dean DeBlois / Chris Sanders / więcej...", "Familijny", "USA", "18 marca 2010 (świat)", "https://fwcdn.pl/fpo/10/14/331014/7318652.6.jpg" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CDs");
        }
    }
}

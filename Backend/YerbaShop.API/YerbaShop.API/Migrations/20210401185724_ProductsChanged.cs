using Microsoft.EntityFrameworkCore.Migrations;

namespace YerbaShop.API.Migrations
{
    public partial class ProductsChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductBrand",
                value: "CBSe");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductBrand",
                value: "Kraus");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ShortDescription",
                value: "Kurupi Clásica 500 g 0,5 kg to paragwajska yerba mate w klasycznym stylu. Cechuje się wspaniałym, szlachetnie goryczkowym aromatem i świetnie pobudza.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ShortDescription",
                value: "Kurupi Katuava Especial 500 g to paragwajska yerba mate z dodatkiem kory catuaby oraz zioła burrito. Ziołowy aromat równoważy goryczkę. Doskonale pobudza.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ShortDescription",
                value: "Kurupi Katuava Especial 1kg to paragwajska yerba mate z dodatkiem kory catuaby oraz zioła burrito. Ziołowy aromat równoważy goryczkę. Doskonale pobudza.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ProductBrand", "ShortDescription" },
                values: new object[] { "Pajarito", "Pajarito Elaborada Con Palo Tradicional 1 kg to tradycyjna yerba mate z Paragwaju. Ma mocny dymny aromat i wyrazisty smak. Dobrze pobudza." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ProductBrand",
                value: "Pajarito");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ShortDescription",
                value: "La Rubia 0,5 kg 500 g to paragwajska yerba mate z organicznym certyfikatem. Nie zawiera dodatków. Cechuje się klasycznym goryczkowym smakiem i świetnie pobudza.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ShortDescription",
                value: "La Rubia 1kg to paragwajska yerba mate z organicznym certyfikatem. Nie zawiera dodatków. Cechuje się klasycznym goryczkowym smakiem i świetnie pobudza.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ShortDescription",
                value: "Yerba Mate Taragüi Energia to klasyczna yerba o zwiększonej zawartości kofeiny, dzięki czemu daje mocny efekt pobudzenia.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ShortDescription",
                value: "Yerba Mate Taragüi Energia to klasyczna yerba o zwiększonej zawartości kofeiny, dzięki czemu daje mocny efekt pobudzenia.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ShortDescription",
                value: "Taragüi Maracuya Tropical 0,5 kg 500 g to argentyńska yerba mate o smaku owocu marakui. Doskonale pobudza, jest świetna na zimno i na ciepło.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ProductImage",
                value: "https://www.poyerbani.pl/pol_pl_Verde-Mate-Green-Detox-0-5kg-4425_1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ProductImage", "ShortDescription" },
                values: new object[] { "https://www.poyerbani.pl/pol_pl_Verde-Mate-Green-Frutos-del-Bosque-0-5kg-4480_1.png", "Verde Mate Frutos del Bosque to połączenie aromatycznej yerba mate ze słodkawymi i kwaskowatymi owocami z europejskich lasów." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ProductImage", "ShortDescription" },
                values: new object[] { "https://www.poyerbani.pl/product-pol-4240-Verde-Mate-Green-Mas-IQ-0-5kg.html", "Verde Mate Más IQ to kompozycja ostrokrzewu paragwajskiego i składników nadających jej delikatnie owocowy smak. Nie brakuje w niej także pożytecznych dodatków!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductBrand",
                value: "Kraus");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductBrand",
                value: "CBSe");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ShortDescription",
                value: "Kurupi Clásica 500 g 0,5 kg to paragwajska yerba mate w klasycznym stylu. Cechuje się wspaniałym, szlachetnie goryczkowym aromatem i świetnie pobudza. Spróbuj!");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ShortDescription",
                value: "Kurupi Katuava Especial 500 g to paragwajska yerba mate z dodatkiem kory catuaby oraz zioła burrito. Ziołowy aromat równoważy goryczkę. Doskonale pobudza. Spróbuj!");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ShortDescription",
                value: "Kurupi Katuava Especial 1kg to paragwajska yerba mate z dodatkiem kory catuaby oraz zioła burrito. Ziołowy aromat równoważy goryczkę. Doskonale pobudza. Spróbuj!");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ProductBrand", "ShortDescription" },
                values: new object[] { "Pajarito ", "Pajarito Elaborada Con Palo Tradicional 1 kg 1000 g to tradycyjna yerba mate z Paragwaju. Ma mocny dymny aromat i wyrazisty smak. Dobrze pobudza. Hit naszego sklepu yerba mate!" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ProductBrand",
                value: "Pajarito ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ShortDescription",
                value: "La Rubia 0,5 kg 500 g to paragwajska yerba mate z organicznym certyfikatem. Nie zawiera dodatków. Cechuje się klasycznym goryczkowym smakiem i świetnie pobudza. Jedna z najlepszych yerba mate na rynku!");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ShortDescription",
                value: "La Rubia 1kg to paragwajska yerba mate z organicznym certyfikatem. Nie zawiera dodatków. Cechuje się klasycznym goryczkowym smakiem i świetnie pobudza. Jedna z najlepszych yerba mate na rynku!");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ShortDescription",
                value: "Yerba Mate Taragüi Energia to klasyczna yerba o zwiększonej zawartości kofeiny, dzięki czemu daje mocny efekt pobudzenia.Polecamy!");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ShortDescription",
                value: "Yerba Mate Taragüi Energia to klasyczna yerba o zwiększonej zawartości kofeiny, dzięki czemu daje mocny efekt pobudzenia.Polecamy!");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ShortDescription",
                value: "Taragüi Maracuya Tropical 0,5 kg 500 g to argentyńska yerba mate o smaku owocu marakui. Doskonale pobudza, jest świetna na zimno i na ciepło. Polecamy!");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ProductImage",
                value: "https://www.poyerbani.pl/pol_pl_Taragui-Maracuya-Tropical-marakuja-0-5kg-1509_1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ProductImage", "ShortDescription" },
                values: new object[] { "https://www.poyerbani.pl/pol_pl_Taragui-Maracuya-Tropical-marakuja-0-5kg-1509_1.png", "Verde Mate Frutos del Bosque to połączenie aromatycznej yerba mate ze słodkawymi i kwaskowatymi owocami z europejskich lasów. Spróbuj koniecznie!" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ProductImage", "ShortDescription" },
                values: new object[] { "https://www.poyerbani.pl/pol_pl_Taragui-Maracuya-Tropical-marakuja-0-5kg-1509_1.png", "Verde Mate Más IQ to kompozycja ostrokrzewu paragwajskiego i składników nadających jej delikatnie owocowy smak. Nie brakuje w niej także pożytecznych dodatków! Warto spróbować!" });
        }
    }
}

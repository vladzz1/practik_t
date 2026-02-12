using Microsoft.EntityFrameworkCore;
using PD411_Shop.Models;

namespace PD411_Shop.Helpers
{
    public static class DbInitializer
    {
        public static void seedCategoryModel(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryModel>().HasData(new CategoryModel[]
            {
                new CategoryModel()
                {
                    Id = 1,
                    Name = "Процесори"
                },
                new CategoryModel()
                {
                    Id = 2,
                    Name = "Материнські плати"
                },
                new CategoryModel()
                {
                    Id = 3,
                    Name = "Відеокарти"
                },
                new CategoryModel()
                {
                    Id = 4,
                    Name = "Оперативна пам'ять"
                },
                new CategoryModel()
                {
                    Id = 5,
                    Name = "Накопичувачі SSD"
                },
                new CategoryModel()
                {
                    Id = 6,
                    Name = "Накопичувачі HDD"
                },
                new CategoryModel()
                {
                    Id = 7,
                    Name = "Блоки живлення"
                },
                new CategoryModel()
                {
                    Id = 8,
                    Name = "Корпуси"
                },
                new CategoryModel()
                {
                    Id = 9,
                    Name = "Повітряне охолодження для CPU"
                },
                new CategoryModel()
                {
                    Id = 10,
                    Name = "Водяне охолодження для CPU"
                }
            });
        }
        public static void seedProductModel(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel[]
            {
                new ProductModel()
                {
                    Id = 1,
                    Name = "AMD Ryzen 7 7800X3D 4.2(5.0)GHz 96MB sAM5 Tray (100-000000910)",
                    Description = null,
                    Price = 16579,
                    Image = "https://img.telemart.ua/503464-641930-category_page/amd-ryzen-7-7800x3d-4250ghz-96mb-sam5-tray-100-100000910.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 2,
                    Name = "AMD Ryzen 5 5500 3.6(4.2)GHz 16MB sAM4 Tray (100-000000457)",
                    Description = null,
                    Price = 3549,
                    Image = "https://img.telemart.ua/417796-568215-category_page/amd-ryzen-5-5500-3642ghz-16mb-sam4-tray-100-000000457.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 3,
                    Name = "AMD Ryzen 5 7500F 3.7(5.0)GHz 32MB sAM5 Tray (100-000000597)",
                    Description = null,
                    Price = 6999,
                    Image = "https://img.telemart.ua/537768-1031541-category_page/amd-ryzen-5-7500f-3750ghz-32mb-sam5-tray-100-000000597.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 4,
                    Name = "AMD Ryzen 7 9800X3D 4.7(5.2)GHz 96MB sAM5 Tray (100-000001084)",
                    Description = null,
                    Price = 21939,
                    Image = "https://img.telemart.ua/711314-878818-category_page/amd-ryzen-7-9800x3d-4752ghz-96mb-sam5-tray-100-000001084.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 5,
                    Name = "AMD Ryzen 7 7700 3.8(5.3)GHz 32MB sAM5 Tray (100-000000592)",
                    Description = null,
                    Price = 10299,
                    Image = "https://img.telemart.ua/537769-686742-category_page/amd-ryzen-7-7700-3853ghz-32mb-sam5-tray-100-000000592.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 6,
                    Name = "AMD Ryzen 5 7500X3D 4.0(4.5)GHz 96MB sAM5 Tray (100-000001904)",
                    Description = null,
                    Price = 11699,
                    Image = "https://img.telemart.ua/826881-1063629-category_page/amd-ryzen-5-7500x3d-4045ghz-96mb-sam5-tray-100-000001904.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 7,
                    Name = "AMD Ryzen 5 5600X 3.7(4.6)GHz 32MB sAM4 Tray (100-000000065)",
                    Description = null,
                    Price = 6399,
                    Image = "https://img.telemart.ua/308346-471419-category_page/amd-ryzen-5-5600x-3746ghz-32mb-sam4-tray-100-000000065.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 8,
                    Name = "AMD Ryzen 7 9700X 3.8(5.5)GHz 32MB sAM5 Tray (100-000001404)",
                    Description = null,
                    Price = 13799,
                    Image = "https://img.telemart.ua/642817-792794-category_page/amd-ryzen-7-9700x-3855ghz-32mb-sam5-tray-100-000001404.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 9,
                    Name = "Intel Core i5-14400F 2.5(4.7)GHz 20MB s1700 Box (BX8071514400F)",
                    Description = null,
                    Price = 8799,
                    Image = "https://img.telemart.ua/593671-736153-category_page/intel-core-i5-14400f-2547ghz-20mb-s1700-box-bx8071514400f.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 10,
                    Name = "AMD Ryzen 5 8400F 4.2(4.7)GHz 16MB sAM5 Tray (100-000001591)",
                    Description = null,
                    Price = 4899,
                    Image = "https://img.telemart.ua/634728-784049-category_page/amd-ryzen-5-8400f-4247ghz-16mb-sam5-tray-100-000001591.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 11,
                    Name = "AMD Ryzen 5 7500X3D 4.0(4.5)GHz 96MB sAM5 Box (100-100001904WOF)",
                    Description = null,
                    Price = 11799,
                    Image = "https://img.telemart.ua/826241-1062681-category_page/amd-ryzen-5-7500x3d-4046ghz-96mb-sam5-box-100-100001904wof.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 12,
                    Name = "AMD Ryzen 7 5700X 3.4(4.6)GHz 32MB sAM4 Multipack (100-100000926NPK)",
                    Description = null,
                    Price = 8599,
                    Image = "https://img.telemart.ua/851350-1102440-category_page/amd-ryzen-7-5700x-3446ghz-32mb-sam4-box-100-100000926npk.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 13,
                    Name = "Intel Core i5-12400F 2.5(4.4)GHz 18MB s1700 Tray (CM8071504555318)",
                    Description = null,
                    Price = 6199,
                    Image = "https://img.telemart.ua/403290-554711-category_page/intel-core-i5-12400f-2544ghz-18mb-s1700-tray-cm8071504555318.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 14,
                    Name = "AMD Ryzen 7 9850X3D 4.7(5.6)GHz 96MB sAM5 Box (100-100001973WOF)",
                    Description = null,
                    Price = 28999,
                    Image = "https://img.telemart.ua/849498-1098146-category_page/amd-ryzen-7-9850x3d-4756ghz-96mb-sam5-box-100-100001973wof.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 15,
                    Name = "AMD Ryzen 9 9950X3D 4.3(5.7)GHz 128MB sAM5 Box (100-100000719WOF)",
                    Description = null,
                    Price = 33999,
                    Image = "https://img.telemart.ua/735550-906731-category_page/amd-ryzen-9-9950x3d-4357ghz-128mb-sam5-box-100-100000719wof.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 16,
                    Name = "Intel Core i5-14600KF 3.5(5.3)GHz 24MB s1700 Box (BX8071514600KF)",
                    Description = null,
                    Price = 10999,
                    Image = "https://img.telemart.ua/538276-687335-category_page/intel-core-i5-14600kf-3553ghz-24mb-s1700-box-bx8071514600kf.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 17,
                    Name = "AMD Ryzen 7 9700X 3.8(5.5)GHz 32MB sAM5 Box (100-100001404WOF)",
                    Description = null,
                    Price = 14899,
                    Image = "https://img.telemart.ua/642818-792792-category_page/amd-ryzen-7-9700x-3855ghz-32mb-sam5-box-100-100001404wof.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 18,
                    Name = "AMD Ryzen 5 9600X 3.9(5.4)GHz 32MB sAM5 Tray (100-000001405)",
                    Description = null,
                    Price = 10099,
                    Image = "https://img.telemart.ua/642819-830377-category_page/amd-ryzen-5-9600x-3954ghz-32mb-sam5-tray-100-000001405.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 19,
                    Name = "Intel Core i7-14700KF 3.4(5.6)GHz 33MB s1700 Box (BX8071514700KF)",
                    Description = null,
                    Price = 17499,
                    Image = "https://img.telemart.ua/538278-687339-category_page/intel-core-i7-14700kf-3456ghz-33mb-s1700-box-bx8071514700kf.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 20,
                    Name = "AMD Ryzen 9 9900X 4.4(5.6)GHz 64MB sAM5 Tray (100-000000662)",
                    Description = null,
                    Price = 19499,
                    Image = "https://img.telemart.ua/642815-792797-category_page/amd-ryzen-9-9900x-4456ghz-64mb-sam5-tray-100-000000662.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 1
                },
                new ProductModel()
                {
                    Id = 21,
                    Name = "Asus PRIME B650M-K (sAM5, AMD B650)",
                    Description = null,
                    Price = 4699,
                    Image = "https://img.telemart.ua/515777-663098-category_page/asus-prime-b650m-k-sam5-amd-b650.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 22,
                    Name = "MSI B850M GAMING PLUS WIFI6E (sAM5, AMD B850)",
                    Description = null,
                    Price = 7499,
                    Image = "https://img.telemart.ua/779682-982425-category_page/msi-b850m-gaming-plus-wifi6e-sam5-amd-b850.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 23,
                    Name = "Gigabyte B550M AORUS ELITE (sAM4, AMD B550)",
                    Description = null,
                    Price = 4499,
                    Image = "https://img.telemart.ua/296930-462349-category_page/gigabyte-b550m-aorus-elite-sam4-amd-b550.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 24,
                    Name = "Asus TUF GAMING B550M-PLUS (sAM4, AMD B550)",
                    Description = null,
                    Price = 5139,
                    Image = "https://img.telemart.ua/270184-486939-category_page/asus-tuf-gaming-b550m-plus-sam4-amd-b550.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 25,
                    Name = "Asus TUF GAMING B850-PLUS WIFI (sAM5, AMD B850)",
                    Description = null,
                    Price = 10499,
                    Image = "https://img.telemart.ua/719299-887950-category_page/asus-tuf-gaming-b850-plus-wifi-sam5-amd-b850.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 26,
                    Name = "MSI B650 GAMING PLUS WIFI (sAM5, AMD B650)",
                    Description = null,
                    Price = 7799,
                    Image = "https://img.telemart.ua/501732-640966-category_page/msi-b650-gaming-plus-wifi-sam5-amd-b650.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 27,
                    Name = "Asus TUF GAMING B850M-E WIFI (sAM5, AMD B850)",
                    Description = null,
                    Price = 8996,
                    Image = "https://img.telemart.ua/771470-966412-category_page/asus-tuf-gaming-b850m-e-wifi-sam5-amd-b850.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 28,
                    Name = "Gigabyte B650M GAMING PLUS WIFI (sAM5, AMD B650)",
                    Description = null,
                    Price = 6399,
                    Image = "https://img.telemart.ua/730509-901144-category_page/gigabyte-b650m-gaming-plus-wifi-sam5-amd-b650.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 29,
                    Name = "Gigabyte B650 EAGLE AX (sAM5, AMD B650)",
                    Description = null,
                    Price = 5999,
                    Image = "https://img.telemart.ua/588018-731769-category_page/gigabyte-b650-eagle-ax-sam5-amd-b650.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 30,
                    Name = "Asus TUF GAMING B850M-PLUS WIFI7 W (sAM5, AMD B850)",
                    Description = null,
                    Price = 11499,
                    Image = "https://img.telemart.ua/789039-995869-category_page/asus-tuf-gaming-b850m-plus-wifi7-w-sam5-amd-b850.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 31,
                    Name = "MSI MEG X870E GODLIKE X EDITION (sAM5, AMD X870E)",
                    Description = null,
                    Price = 62999,
                    Image = "https://img.telemart.ua/822669-1055259-category_page/msi-meg-x870e-godlike-x-edition-sam5-amd-x870e.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 32,
                    Name = "MSI MAG B850 TOMAHAWK MAX WIFI (sAM5, AMD B850)",
                    Description = null,
                    Price = 13499,
                    Image = "https://img.telemart.ua/720854-890471-category_page/msi-mag-b850-tomahawk-max-wifi-sam5-amd-b850.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 33,
                    Name = "Asus ROG STRIX B760-G GAMING WIFI (s1700, Intel B760)",
                    Description = null,
                    Price = 8029,
                    Image = "https://img.telemart.ua/490842-630262-category_page/asus-rog-strix-b760-g-gaming-wifi-s1700-intel-b760.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 34,
                    Name = "Asus ROG STRIX X870-I GAMING WIFI (sAM5, AMD X870)",
                    Description = null,
                    Price = 18999,
                    Image = "https://img.telemart.ua/666977-850975-category_page/asus-rog-strix-x870-i-gaming-wifi-sam5-amd-x870.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 35,
                    Name = "Asus TUF GAMING B650-PLUS (sAM5, AMD B650)",
                    Description = null,
                    Price = 7799,
                    Image = "https://img.telemart.ua/437880-586147-category_page/asus-tuf-gaming-b650-plus.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 36,
                    Name = "Asus ROG STRIX B850-E GAMING WIFI (sAM5, AMD B850)",
                    Description = null,
                    Price = 15999,
                    Image = "https://img.telemart.ua/719296-887919-category_page/asus-rog-strix-b850-e-gaming-wifi-sam5-amd-b850.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 37,
                    Name = "Asus X870 MAX GAMING WIFI7 W (sAM5, AMD X870)",
                    Description = null,
                    Price = 13999,
                    Image = "https://img.telemart.ua/754585-938421-category_page/asus-x870-max-gaming-wifi7-w-sam5-amd-x870.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 38,
                    Name = "Asus ROG STRIX B850-F GAMING WIFI (sAM5, AMD B850)",
                    Description = null,
                    Price = 13499,
                    Image = "https://img.telemart.ua/719297-887929-category_page/asus-rog-strix-b850-f-gaming-wifi-sam5-amd-b850.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 39,
                    Name = "Asus ROG STRIX B760-A GAMING WIFI (s1700, Intel B760)",
                    Description = null,
                    Price = 10299,
                    Image = "https://img.telemart.ua/496655-635865-category_page/asus-rog-strix-b760-a-gaming-wifi-s1700-intel-b760.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 40,
                    Name = "Asus TUF GAMING B850-BTF WIFI W (sAM5, AMD B850)",
                    Description = null,
                    Price = 11799,
                    Image = "https://img.telemart.ua/754591-939305-category_page/asus-tuf-gaming-b850-btf-wifi-w-sam5-amd-b850.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 2
                },
                new ProductModel()
                {
                    Id = 41,
                    Name = "Asus Dual GeForce RTX 5060 OC 8192MB (DUAL-RTX5060-O8G)",
                    Description = null,
                    Price = 17999,
                    Image = "https://img.telemart.ua/757515-941984-category_page/asus-dual-geforce-rtx-5060-oc-8192mb-dual-rtx5060-o8g.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 42,
                    Name = "Asus ROG Matrix Platinum RTX 5090 30th Anniversary Edition 32768MB (ROG-MATRIX-RTX5090-P32G-30TH)",
                    Description = null,
                    Price = 314999,
                    Image = "https://img.telemart.ua/837162-1077227-category_page/asus-rog-matrix-platinum-rtx-5090-30th-anniversary-edition-32768mb-rog-matrix-rtx5090-p32g-30th.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 43,
                    Name = "Gigabyte GeForce RTX 5060 WINDFORCE MAX OC 8192MB (GV-N5060WF2MAX OC-8GD)",
                    Description = null,
                    Price = 16999,
                    Image = "https://img.telemart.ua/788569-994342-category_page/gigabyte-geforce-rtx-5060-windforce-max-oc-8192mb-gv-n5060wf2max-oc-8gd.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 44,
                    Name = "Asus PRIME GeForce RTX 5070 OC 12288MB (PRIME-RTX5070-O12G)",
                    Description = null,
                    Price = 37499,
                    Image = "https://img.telemart.ua/721158-973442-category_page/asus-prime-geforce-rtx-5070-oc-12288mb-prime-rtx5070-o12g.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 45,
                    Name = "Gigabyte GeForce RTX 5070 WINDFORCE SFF OC 12288MB (GV-N5070WF3OC-12GD)",
                    Description = null,
                    Price = 34999,
                    Image = "https://img.telemart.ua/712904-898331-category_page/gigabyte-geforce-rtx-5070-windforce-oc-12288mb-gv-n5070wf3oc-12gd.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 46,
                    Name = "Gigabyte GeForce RTX 5070 Ti GAMING OC 16384MB (GV-N507TGAMING OC-16GD)",
                    Description = null,
                    Price = 58999,
                    Image = "https://img.telemart.ua/712893-1008567-category_page/gigabyte-geforce-rtx-5070-ti-gaming-oc-16384mb-gv-n507tgaming-oc-16gd.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 47,
                    Name = "Gigabyte GeForce RTX 5070 GAMING OC 12288MB (GV-N5070GAMING OC-12GD)",
                    Description = null,
                    Price = 36999,
                    Image = "https://img.telemart.ua/712899-1008557-category_page/gigabyte-geforce-rtx-5070-gaming-oc-12288mb-gv-n5070gaming-oc-12gd.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 48,
                    Name = "Gigabyte GeForce RTX 5070 AORUS MASTER 12288MB (GV-N5070AORUS M-12GD)",
                    Description = null,
                    Price = 42699,
                    Image = "https://img.telemart.ua/712900-898223-category_page/gigabyte-geforce-rtx-5070-aorus-master-12288mb-gv-n5070aorus-m-12gd.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 49,
                    Name = "Gigabyte GeForce RTX 5070 Ti WINDFORCE SFF OC 16384MB (GV-N507TWF3OC-16GD)",
                    Description = null,
                    Price = 58999,
                    Image = "https://img.telemart.ua/712898-898321-category_page/gigabyte-geforce-rtx-5070-ti-windforce-oc-16384mb-gv-n507twf3oc-16gd.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 50,
                    Name = "Asus Dual GeForce RTX 5060 Ti OC 16384MB (DUAL-RTX5060TI-O16G)",
                    Description = null,
                    Price = 31499,
                    Image = "https://img.telemart.ua/757528-942008-category_page/asus-dual-geforce-rtx-5060-ti-oc-16384mb-dual-rtx5060ti-o16g.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 51,
                    Name = "Asus PRIME GeForce RTX 5070 Ti OC 16384MB (PRIME-RTX5070TI-O16G)",
                    Description = null,
                    Price = 60999,
                    Image = "https://img.telemart.ua/721162-896365-category_page/asus-prime-geforce-rtx-5070-ti-oc-16384mb-prime-rtx5070ti-o16g.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 52,
                    Name = "Asus Dual GeForce RTX 5070 OC 12288MB (DUAL-RTX5070-O12G)",
                    Description = null,
                    Price = 36499,
                    Image = "https://img.telemart.ua/761103-946774-category_page/asus-dual-geforce-rtx-5070-oc-12288mb-dual-rtx5070-o12g.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 53,
                    Name = "Asus ROG Astral GeForce RTX 5090 OC 32768MB (ROG-ASTRAL-RTX5090-O32G-GAMING)",
                    Description = null,
                    Price = 189999,
                    Image = "https://img.telemart.ua/721174-896470-category_page/asus-rog-astral-geforce-rtx-5090-oc-32768mb-rog-astral-rtx5090-o32g-gaming.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 54,
                    Name = "Asus GeForce RTX 5080 Noctua OC 16384MB (RTX5080-O16G-NOCTUA)",
                    Description = null,
                    Price = 95999,
                    Image = "https://img.telemart.ua/771442-1011115-category_page/asus-geforce-rtx-5080-noctua-oc-16384mb-rtx5080-o16g-noctua.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 55,
                    Name = "Inno3D GeForce RTX 5090 X3 OC 32768MB (N50903-32D7X-17593928)",
                    Description = null,
                    Price = 167999,
                    Image = "https://img.telemart.ua/758165-943507-category_page/inno3d-geforce-rtx-5090-x3-oc-32768mb-n50903-32d7x-17593928.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 56,
                    Name = "Inno3D GeForce RTX 5080 iCHILL X3 16384MB (C50803-16D7X-176069R)",
                    Description = null,
                    Price = 79999,
                    Image = "https://img.telemart.ua/820501-1051379-category_page/inno3d-geforce-rtx-5080-ichill-x3-16384mb-c50803-16d7x-176069r.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 57,
                    Name = "Inno3D GeForce RTX 5080 X3 OC 16384MB (N50803-16D7X-17603930)",
                    Description = null,
                    Price = 69999,
                    Image = "https://img.telemart.ua/721720-889341-category_page/inno3d-geforce-rtx-5080-x3-oc-16384mb-n50803-16d7x-17603930.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 58,
                    Name = "Inno3D GeForce RTX 5070 Ti iCHILL X3 16384MB (C507T3-16D7X-176069R)",
                    Description = null,
                    Price = 59999,
                    Image = "https://img.telemart.ua/820217-1051315-category_page/inno3d-geforce-rtx-5070-ti-ichill-x3-16384mb-c507t3-16d7x-176069r.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 59,
                    Name = "Inno3D GeForce RTX 5060 Ti TWIN X2 OC 16384MB (N506T2-16D7X-191073N)",
                    Description = null,
                    Price = 29499,
                    Image = "https://img.telemart.ua/757625-941653-category_page/inno3d-geforce-rtx-5060-ti-twin-x2-oc-16384mb-n506t2-16d7x-191073n.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 60,
                    Name = "Gigabyte GeForce RTX 5070 EAGLE SFF OC 12288MB (GV-N5070EAGLE OC-12GD)",
                    Description = null,
                    Price = 35999,
                    Image = "https://img.telemart.ua/712903-898243-category_page/gigabyte-geforce-rtx-5070-eagle-oc-12288mb-gv-n5070eagle-oc-12gd.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 3
                },
                new ProductModel()
                {
                    Id = 61,
                    Name = "Kingston DDR5 32GB (2x16GB) 6000Mhz FURY Beast Black (KF560C36BBE2K2-32)",
                    Description = null,
                    Price = 17999,
                    Image = "https://img.telemart.ua/669406-826235-category_page/kingston-ddr5-32gb-2x16gb-6000mhz-fury-beast-black-kf560c36bbe2k2-32.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 62,
                    Name = "Kingston DDR4 16GB (2x8GB) 3200Mhz FURY Beast Black (KF432C16BBK2/16)",
                    Description = null,
                    Price = 5989,
                    Image = "https://img.telemart.ua/374722-1099287-category_page/kingston-ddr4-16gb-2x8gb-3200mhz-fury-beast-black-kf432c16bbk216.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 63,
                    Name = "Kingston DDR5 32GB (2x16GB) 6000Mhz FURY Beast Black (KF560C30BBEK2-32)",
                    Description = null,
                    Price = 19699,
                    Image = "https://img.telemart.ua/619187-764873-category_page/kingston-ddr5-32gb-2x16gb-6000mhz-fury-beast-black-kf560c30bbek2-32.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 64,
                    Name = "Kingston DDR4 32GB (2x16GB) 3200Mhz FURY Beast Black (KF432C16BB1K2/32)",
                    Description = null,
                    Price = 9499,
                    Image = "https://img.telemart.ua/374725-526249-category_page/kingston-ddr4-32gb-2x16gb-3200mhz-fury-beast-black-kf432c16bb1k232.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 65,
                    Name = "Kingston DDR5 32GB (2x16GB) 6000Mhz FURY Beast Black (KF560C30BBK2-32)",
                    Description = null,
                    Price = 19599,
                    Image = "https://img.telemart.ua/619247-765478-category_page/kingston-ddr5-32gb-2x16gb-6000mhz-fury-beast-black-kf560c30bbk2-32.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 66,
                    Name = "Kingston DDR4 32GB (2x16GB) 3600Mhz FURY Beast Black (KF436C18BBK2/32)",
                    Description = null,
                    Price = 9799,
                    Image = "https://img.telemart.ua/374737-526274-category_page/kingston-ddr4-32gb-2x16gb-3600mhz-fury-beast-black-kf436c18bbk232.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 67,
                    Name = "Kingston DDR5 32GB (2x16GB) 5200Mhz FURY Beast Black (KF552C40BBK2-32)",
                    Description = null,
                    Price = 13999,
                    Image = "https://img.telemart.ua/390312-542686-category_page/kingston-ddr5-32gb-2x16gb-5200mhz-fury-beast-black-kf552c40bbk2-32.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 68,
                    Name = "Kingston SODIMM DDR4 32GB (2x16GB) 3200Mhz FURY Impact Black (KF432S20IBK2/32)",
                    Description = null,
                    Price = 9719,
                    Image = "https://img.telemart.ua/374679-523387-category_page/kingston-sodimm-ddr4-32gb-2x16gb-3200mhz-fury-impact-black-kf432s20ibk232.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 69,
                    Name = "Kingston DDR5 64GB (2x32GB) 6400Mhz FURY Beast Black (KF564C32BBK2-64)",
                    Description = null,
                    Price = 39999,
                    Image = "https://img.telemart.ua/619258-765725-category_page/kingston-ddr5-64gb-2x32gb-6400mhz-fury-beast-black-kf564c32bbk2-64.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 70,
                    Name = "G.Skill DDR4 16GB (2x8GB) 3200Mhz Aegis (F4-3200C16D-16GIS)",
                    Description = null,
                    Price = 5729,
                    Image = "https://img.telemart.ua/205723-393078-category_page/gskill-ddr4-16gb-2x8gb-3200mhz-aegis-f4-3200c16d-16gis.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 71,
                    Name = "G.Skill DDR4 32GB (2x16GB) 3200Mhz Ripjaws V (F4-3200C16D-32GVK)",
                    Description = null,
                    Price = 9799,
                    Image = "https://img.telemart.ua/80823-554140-category_page/gskill-ddr4-32gb-2x16gb-3200mhz-ripjaws-v-f4-3200c16d-32gvk.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 72,
                    Name = "Corsair DDR4 32GB (2x16GB) 3600Mhz Vengeance LPX Black (CMK32GX4M2D3600C18)",
                    Description = null,
                    Price = 9799,
                    Image = "https://img.telemart.ua/327406-480969-category_page/corsair-ddr4-32gb-2x16gb-3600mhz-vengeance-lpx-black-cmk32gx4m2d3600c18.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 73,
                    Name = "Patriot DDR5 32GB (2x16GB) 6000Mhz Viper Venom (PVV532G600C36K)",
                    Description = null,
                    Price = 16299,
                    Image = "https://img.telemart.ua/591587-735805-category_page/patriot-ddr5-32gb-2x16gb-6000mhz-viper-venom-pvv532g600c36k.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 74,
                    Name = "G.Skill DDR4 32GB (2x16GB) 3200Mhz Aegis (F4-3200C16D-32GIS)",
                    Description = null,
                    Price = 10399,
                    Image = "https://img.telemart.ua/205725-393084-category_page/gskill-ddr4-32gb-2x16gb-3200mhz-aegis-f4-3200c16d-32gis.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 75,
                    Name = "G.Skill DDR4 16GB (2x8GB) 3200Mhz Ripjaws V (F4-3200C16D-16GVKB)",
                    Description = null,
                    Price = 5909,
                    Image = "https://img.telemart.ua/71720-478561-category_page/gskill-ddr4-16gb-2x8gb-3200mhz-ripjaws-v-f4-3200c16d-16gvkb.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 76,
                    Name = "Kingston DDR4 32GB (2x16GB) 3200Mhz FURY Beast Black (KF432C16BBK2/32)",
                    Description = null,
                    Price = 10899,
                    Image = "https://img.telemart.ua/374728-1047822-category_page/kingston-ddr4-32gb-2x16gb-3200mhz-fury-beast-black-kf432c16bbk232.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 77,
                    Name = "Kingston DDR5 16GB 5600Mhz FURY Beast Black (KF556C40BB-16)",
                    Description = null,
                    Price = 8999,
                    Image = "https://img.telemart.ua/399081-551397-category_page/kingston-ddr5-16gb-5600mhz-fury-beast-black-kf556c40bb-16.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 78,
                    Name = "Lexar DDR4 16GB (2x8GB) 3600Mhz Thor White (LD4BU008G-R3600GDWG)",
                    Description = null,
                    Price = 5399,
                    Image = "https://img.telemart.ua/627136-773063-category_page/lexar-ddr4-16gb-2x8gb-3600mhz-thor-white-ld4bu008g-r3600gdwg.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 79,
                    Name = "G.Skill DDR5 32GB (2x16GB) 6000Mhz Trident Z5 Neo RGB White (F5-6000J3036F16GX2-TZ5NRW)",
                    Description = null,
                    Price = 22999,
                    Image = "https://img.telemart.ua/564610-712835-category_page/gskill-ddr5-32gb-2x16gb-6000mhz-trident-z5-neo-rgb-white-f5-6000j3036f16gx2-tz5nrw.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 80,
                    Name = "G.Skill DDR5 32GB (2x16GB) 6000Mhz Flare X5 (F5-6000J3038F16GX2-FX5)",
                    Description = null,
                    Price = 19999,
                    Image = "https://img.telemart.ua/591162-734940-category_page/gskill-ddr5-32gb-2x16gb-6000mhz-flare-x5-f5-6000j3038f16gx2-fx5.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 4
                },
                new ProductModel()
                {
                    Id = 81,
                    Name = "Kingston NV3 3D NAND 1TB M.2 (2280 PCI-E) NVMe x4 (SNV3S/1000G)",
                    Description = null,
                    Price = 7989,
                    Image = "https://img.telemart.ua/659314-814483-category_page/kingston-nv3-3d-nand-1tb-m2-2280-pci-e-nvme-x4-snv3s1000g.jpg",
                    Amount = 0,
                    Color = "Синій",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 82,
                    Name = "Samsung 990 PRO V-NAND 3-bit MLC 1TB M.2 (2280 PCI-E) NVMe 2.0 (MZ-V9P1T0BW)",
                    Description = null,
                    Price = 9799,
                    Image = "https://img.telemart.ua/445260-588761-category_page/samsung-990-pro-v-nand-3-bit-mlc-1tb-m2-2280-pci-e-nvme-20-mz-v9p1t0bw.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 83,
                    Name = "Kingston KC3000 3D NAND TLC 1TB M.2 (2280 PCI-E) NVMe x4 (SKC3000S/1024G)",
                    Description = null,
                    Price = 12689,
                    Image = "https://img.telemart.ua/390090-542534-category_page/kingston-kc3000-3d-nand-tlc-1tb-m2-2280-pci-e-nvme-x4-skc3000s1024g.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 84,
                    Name = "Samsung 990 PRO V-NAND 3-bit MLC 2TB M.2 (2280 PCI-E) NVMe 2.0 (MZ-V9P2T0BW)",
                    Description = null,
                    Price = 15099,
                    Image = "https://img.telemart.ua/445261-588773-category_page/samsung-990-pro-v-nand-3-bit-mlc-2tb-m2-2280-pci-e-nvme-20-mz-v9p2t0bw.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 85,
                    Name = "Kingston NV3 3D NAND 500GB M.2 (2280 PCI-E) NVMe x4 (SNV3S/500G)",
                    Description = null,
                    Price = 4989,
                    Image = "https://img.telemart.ua/659313-814492-category_page/kingston-nv3-3d-nand-500gb-m2-2280-pci-e-nvme-x4-snv3s500g.jpg",
                    Amount = 0,
                    Color = "Синій",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 86,
                    Name = "Kingston NV3 3D NAND 2TB M.2 (2280 PCI-E) NVMe x4 (SNV3S/2000G)",
                    Description = null,
                    Price = 15299,
                    Image = "https://img.telemart.ua/659315-814486-category_page/kingston-nv3-3d-nand-2tb-m2-2280-pci-e-nvme-x4-snv3s2000g.jpg",
                    Amount = 0,
                    Color = "Синій",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 87,
                    Name = "Kingston SSDNow A400 TLC 480GB 2.5'' (SA400S37/480G)",
                    Description = null,
                    Price = 5089,
                    Image = "https://img.telemart.ua/67022-425930-category_page/kingston-ssdnow-a400-tlc-480gb-25-sa400s37480g.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 88,
                    Name = "Western Digital Black SN7100 3D NAND TLC 1TB M.2 (2280 PCI-E) NVMe x4 (WDS100T4X0E)",
                    Description = null,
                    Price = 8799,
                    Image = "https://img.telemart.ua/762637-950354-category_page/western-digital-black-sn7100-3d-nand-tlc-1tb-m2-2280-pci-e-nvme-x4-wds100t4x0e.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 89,
                    Name = "Patriot P400 Lite 1TB M.2 (2280 PCI-E) NVMe x4 (P400LP1KGM28H)",
                    Description = null,
                    Price = 6099,
                    Image = "https://img.telemart.ua/487293-626221-category_page/patriot-p400-lite-1tb-m2-2280-pci-e-nvme-x4-p400lp1kgm28h.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 90,
                    Name = "GoodRAM CX400 Gen.2 3D NAND TLC 128GB 2.5\" (SSDPR-CX400-128-G2)",
                    Description = null,
                    Price = 1229,
                    Image = "https://img.telemart.ua/320863-477300-category_page/goodram-cx400-gen2-3d-nand-tlc-128gb-25-ssdpr-cx400-128-g2.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 91,
                    Name = "Kingston FURY Renegade G5 3D NAND TLC 2TB M.2 (2280 PCI-E) NVMe x4 (SFYR2S/2T0)",
                    Description = null,
                    Price = 26439,
                    Image = "https://img.telemart.ua/754925-936926-category_page/kingston-fury-renegade-g5-3d-tlc-nand-2tb-m2-2280-pci-e-nvme-x4-sfyr2s2t0.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 92,
                    Name = "Kingston FURY Renegade with Heatsink 3D NAND TLC 1TB M.2 (2280 PCI-E) NVMe x4 (SFYRSK/1000G)",
                    Description = null,
                    Price = 14649,
                    Image = "https://img.telemart.ua/446792-589426-category_page/kingston-fury-renegade-with-heatsink-3d-nand-tlc-1tb-m2-2280-pci-e-nvme-x4-sfyrsk1000g.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 93,
                    Name = "Crucial P3 Plus 3D NAND 2TB M.2 (2280 PCI-E) (CT2000P3PSSD8)",
                    Description = null,
                    Price = 11899,
                    Image = "https://img.telemart.ua/467612-604457-category_page/crucial-p3-plus-3d-nand-2tb-m2-2280-pci-e-ct2000p3pssd8.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 94,
                    Name = "ORICO e3500 3D NAND QLC 1TB M.2 (2280 PCI-E) NVMe x4 (ORICO-e3500-1TB-BL-BP)",
                    Description = null,
                    Price = 5299,
                    Image = "https://img.telemart.ua/849544-1098577-category_page/orico-e3500-3d-nand-qlc-1tb-m2-2280-pci-e-nvme-x4-orico-e3500-1tb-bl-bp.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 95,
                    Name = "ORICO e7400 3D NAND QLC 512GB M.2 (2280 PCI-E) NVMe x4 (ORICO-e7400-512GB-GD-BP)",
                    Description = null,
                    Price = 3899,
                    Image = "https://img.telemart.ua/849547-1098696-category_page/orico-e7400-3d-nand-qlc-512gb-m2-2280-pci-e-nvme-x4-orico-e7400-512gb-gd-bp.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 96,
                    Name = "ORICO e3500 3D NAND QLC 512GB M.2 (2280 PCI-E) NVMe x4 (ORICO-e3500-512GB-BL-BP)",
                    Description = null,
                    Price = 3399,
                    Image = "https://img.telemart.ua/849543-1098641-category_page/orico-e3500-3d-nand-qlc-512gb-m2-2280-pci-e-nvme-x4-orico-e3500-512gb-bl-bp.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 97,
                    Name = "Samsung 870 EVO V-NAND 1TB 2.5\" (MZ-77E1T0B)",
                    Description = null,
                    Price = 8639,
                    Image = "https://img.telemart.ua/467625-604518-category_page/samsung-870-evo-v-nand-1tb-25-mz-77e1t0b.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 98,
                    Name = "Patriot P300 512GB M.2 (2280 PCI-E) NVMe x4 (P300P512GM28)",
                    Description = null,
                    Price = 3839,
                    Image = "https://img.telemart.ua/243281-427376-category_page/patriot-p300-512gb-m2-2280-pci-e-nvme-x4-p300p512gm28.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 99,
                    Name = "Kingston FURY Renegade 3D NAND TLC 1TB M.2 (2280 PCI-E) NVMe x4 (SFYRS/1000G)",
                    Description = null,
                    Price = 9999,
                    Image = "https://img.telemart.ua/390094-542522-category_page/kingston-fury-renegade-3d-nand-tlc-1tb-m2-2280-pci-e-nvme-x4-sfyrs1000g.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 100,
                    Name = "Kingston KC3000 3D NAND TLC 512GB M.2 (2280 PCI-E) NVMe x4 (SKC3000S/512G)",
                    Description = null,
                    Price = 7989,
                    Image = "https://img.telemart.ua/390089-542543-category_page/kingston-kc3000-3d-nand-tlc-512gb-m2-2280-pci-e-nvme-x4-skc3000s512g.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 5
                },
                new ProductModel()
                {
                    Id = 101,
                    Name = "Toshiba P300 2TB 256MB 7200RPM 3.5'' (HDWD320UZSVA) Bulk",
                    Description = null,
                    Price = 4999,
                    Image = "https://img.telemart.ua/487304-626256-category_page/toshiba-p300-2tb-128mb-5400rpm-35-hdwd320uzsva-bulk.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 102,
                    Name = "Western Digital Blue 1TB 64MB 3.5\" (WD10EZEX)",
                    Description = null,
                    Price = 4399,
                    Image = "https://img.telemart.ua/11483-907265-category_page/western-digital-caviar-blue-1tb-64mb-7200rpm-35-wd10ezex.png",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 103,
                    Name = "Toshiba 500GB 32MB 7200RPM 3.5\" (DT01ACA050)",
                    Description = null,
                    Price = 1399,
                    Image = "https://img.telemart.ua/11472-357613-category_page/toshiba-500gb-32mb-7200rpm-35-dt01aca050.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 104,
                    Name = "Western Digital Red Plus NAS 8TB 256MB 7200RPM 3.5\" (WD80EFBX) (Відновлено продавцем, 835675)",
                    Description = null,
                    Price = 4499,
                    Image = "https://img.telemart.ua/835675-1075217-category_page/western-digital-red-plus-nas-8tb-256mb-7200rpm-35-wd80efbx-vosstanovleno-prodavtsom.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 105,
                    Name = "Western Digital Purple Surveillance 8TB 256MB 7200RPM 3.5\" (WD82PURZ) (Відновлено продавцем, 835676)",
                    Description = null,
                    Price = 4299,
                    Image = "https://img.telemart.ua/835676-1075214-category_page/western-digital-purple-surveillance-8tb-256mb-7200rpm-35-wd82purz-vosstanovleno-prodavtsom.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 106,
                    Name = "Western Digital Purple Surveillance 10TB 256MB 7200RPM 3.5\" (WD102PURZ) (Відновлено продавцем, 835670)",
                    Description = null,
                    Price = 4999,
                    Image = "https://img.telemart.ua/835670-1075210-category_page/western-digital-purple-surveillance-10tb-256mb-7200rpm-35-wd102purz-vosstanovleno-prodavtsom.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 107,
                    Name = "Western Digital Gold Enterprise Class 16TB 512MB 7200RPM 3.5'' (WD161KRYZ) (Відновлено продавцем, 835674)",
                    Description = null,
                    Price = 9499,
                    Image = "https://img.telemart.ua/835674-1075209-category_page/western-digital-gold-enterprise-class-16tb-512mb-7200rpm-35-wd161kryz-vosstanovleno-prodavtsom.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 108,
                    Name = "Western Digital Ultrastar DC HC550 512e/4Kn 18TB 7200RPM 3.5\" (WUH721818ALE6L4/0F38459) (Відновлено продавцем, 835668)",
                    Description = null,
                    Price = 10999,
                    Image = "https://img.telemart.ua/835668-1075179-category_page/western-digital-ultrastar-dc-hc550-512e4kn-18tb-7200rpm-35-wuh721818ale6l40f38459-vosstanovleno-prodavtsom.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 109,
                    Name = "Seagate IronWolf Pro (NAS) 14TB 512e 256MB 7200RPM 3.5\" (ST14000NE0008) (Відновлено продавцем, 835666)",
                    Description = null,
                    Price = 7499,
                    Image = "https://img.telemart.ua/835666-1075204-category_page/seagate-ironwolf-pro-nas-14tb-512e-256mb-7200rpm-35-st14000ne0008-vosstanovleno-prodavtsom.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 110,
                    Name = "Western Digital Red Plus NAS 14TB 512MB 7200RPM 3.5\" (WD140EFGX) (Відновлено продавцем, 835671)",
                    Description = null,
                    Price = 7499,
                    Image = "https://img.telemart.ua/835671-1075216-category_page/western-digital-red-plus-nas-14tb-512mb-7200rpm-35-wd140efgx-vosstanovleno-prodavtsom.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 111,
                    Name = "Western Digital Red Pro 16TB 512MB 7200RPM 3.5'' (WD161KFGX) (Відновлено продавцем, 835673)",
                    Description = null,
                    Price = 9499,
                    Image = "https://img.telemart.ua/835673-1075218-category_page/western-digital-red-pro-16tb-512mb-7200rpm-35-wd161kfgx-vosstanovleno-prodavtsom.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 112,
                    Name = "Seagate Exos X18 512E/4kn 18TB 3.5\" (ST18000NM000J) (Відновлено продавцем, 835667)",
                    Description = null,
                    Price = 10999,
                    Image = "https://img.telemart.ua/835667-1075182-category_page/seagate-exos-x18-512e4kn-18tb-35-st18000nm000j-vosstanovleno-prodavtsom.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 113,
                    Name = "Seagate BarraCuda 2TB 256MB 7200RPM 3.5\" (ST2000DM008)",
                    Description = null,
                    Price = 5299,
                    Image = "https://img.telemart.ua/89152-407357-category_page/seagate-barracuda-2tb-256mb-7200rpm-35-st2000dm008.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 114,
                    Name = "Seagate SkyHawk Surveillance 8TB 256MB 7200RPM 3.5\" (ST8000VX004) (Відновлено продавцем, 828679)",
                    Description = null,
                    Price = 4499,
                    Image = "https://img.telemart.ua/828679-1066435-category_page/seagate-skyhawk-surveillance-8tb-256mb-7200rpm-35-st8000vx004-828679.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 115,
                    Name = "Western Digital Blue 4TB 128MB 5400RPM 3.5\" (WD40EZZX) (Пошкоджено пакування, 846915)",
                    Description = null,
                    Price = 6799,
                    Image = null,
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 116,
                    Name = "Western Digital Blue 4TB 128MB 5400RPM 3.5\" (WD40EZZX)",
                    Description = null,
                    Price = 8499,
                    Image = "https://img.telemart.ua/844054-1088944-category_page/western-digital-blue-4tb-128mb-5400rpm-35-wd40ezzx.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 117,
                    Name = "Seagate BarraCuda 4TB 256MB 5400RPM 3.5'' (ST4000DM004)",
                    Description = null,
                    Price = 7599,
                    Image = "https://img.telemart.ua/69709-231027-category_page/seagate-barracuda-4tb-256mb-5400rpm-35-st4000dm004.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 118,
                    Name = "Seagate SkyHawk 1TB 256MB 5400RPM 3.5\" (ST1000VX013)",
                    Description = null,
                    Price = 3999,
                    Image = "https://img.telemart.ua/635742-785328-category_page/seagate-skyhawk-1tb-256mb-5400rpm-35-st1000vx013.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 119,
                    Name = "Seagate SkyHawk 2TB 256MB 5400RPM 3.5\" (ST2000VX017)",
                    Description = null,
                    Price = 4499,
                    Image = "https://img.telemart.ua/635745-785332-category_page/seagate-skyhawk-2tb-256mb-5400rpm-35-st2000vx017.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 120,
                    Name = "Seagate BarraCuda 4TB 128MB 5400RPM 2.5'' (ST4000LM024)",
                    Description = null,
                    Price = 6999,
                    Image = "https://img.telemart.ua/61937-407372-category_page/seagate-barracuda-4tb-128mb-5400rpm-25-st4000lm024.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 6
                },
                new ProductModel()
                {
                    Id = 121,
                    Name = "Gigabyte P650SS 650W (GP-P650SS) Black",
                    Description = null,
                    Price = 2499,
                    Image = "https://img.telemart.ua/628001-775130-category_page/gigabyte-p650ss-650w-gp-p650ss-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 122,
                    Name = "Gigabyte P750GM 750W (GP-P750GM)",
                    Description = null,
                    Price = 3999,
                    Image = "https://img.telemart.ua/307833-661708-category_page/gigabyte-p750gm-750w-gp-p750gm.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 123,
                    Name = "Be Quiet! Pure Power 12 M 850W (BN344)",
                    Description = null,
                    Price = 6092,
                    Image = "https://img.telemart.ua/470850-873378-category_page/be-quiet-pure-power-12-m-850w-bn344.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 124,
                    Name = "MSI MPG 850W PCIE5 (A850GS PCIE5)",
                    Description = null,
                    Price = 7099,
                    Image = "https://img.telemart.ua/728270-897725-category_page/msi-mpg-850w-pcie5-a850gs-pcie5.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 125,
                    Name = "Be Quiet! System Power 11 U 750W (BP012EU)",
                    Description = null,
                    Price = 3579,
                    Image = "https://img.telemart.ua/759301-943899-category_page/be-quiet-system-power-11-u-750w-bp012us.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 126,
                    Name = "Gigabyte P650G PCIE 5.1 650W (GP-P650G PG5)",
                    Description = null,
                    Price = 2999,
                    Image = "https://img.telemart.ua/791730-1000178-category_page/gigabyte-p650g-pcie-51-650w-gp-p650g-pg5.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 127,
                    Name = "Asus ROG Strix PCIE5 1200W Aura Edition (90YE00P0-B0NA00)",
                    Description = null,
                    Price = 12439,
                    Image = "https://img.telemart.ua/527494-677320-category_page/asus-rog-strix-pcie5-1200w-aura-edition-90ye00p0-b0na00.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 128,
                    Name = "MSI MAG 850W PCIE5 (A850GL)",
                    Description = null,
                    Price = 5699,
                    Image = "https://img.telemart.ua/526140-674842-category_page/msi-mag-850w-pcie5-a850gl.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 129,
                    Name = "Gigabyte AE1000PM PG5 1000W (GP-AE1000PM PG5) Black",
                    Description = null,
                    Price = 8499,
                    Image = "https://img.telemart.ua/640608-790765-category_page/gigabyte-ae1000pm-pg5-1000w-gp-ae1000pm-pg5-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 130,
                    Name = "Gigabyte UD1600PM PG5 1600W (GP-UD1600PM PG5)",
                    Description = null,
                    Price = 16999,
                    Image = "https://img.telemart.ua/642862-793889-category_page/gigabyte-ud1600pm-pg5-1600w-gp-ud1600pm-pg5.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 131,
                    Name = "NZXT C1200W ATX 3.1 (PA-2G2BB-EU) Black",
                    Description = null,
                    Price = 12199,
                    Image = "https://img.telemart.ua/730053-900333-category_page/nzxt-c1200w-atx-31-pa-2g2bb-eu-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 132,
                    Name = "Asus ROG Thor 1200W Platinum III Hatsune Miku Edition (90YE00V6-B0NA00)",
                    Description = null,
                    Price = 24999,
                    Image = "https://img.telemart.ua/821565-1053411-category_page/asus-rog-thor-1200w-platinum-iii-hatsune-miku-edition-90ye00v6-b0na00.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 133,
                    Name = "Asus ROG Thor 1000W Platinum III (90YE00V3-B0NA00)",
                    Description = null,
                    Price = 20999,
                    Image = "https://img.telemart.ua/761776-947567-category_page/asus-rog-thor-1000w-platinum-iii-90ye00v3-b0na00.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 134,
                    Name = "Be Quiet! System Power 11 U 650W (BP011EU)",
                    Description = null,
                    Price = 3119,
                    Image = "https://img.telemart.ua/759302-943896-category_page/be-quiet-system-power-11-u-650w-bp011us.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 135,
                    Name = "MSI MAG 1000W PCIE5 (A1000GL)",
                    Description = null,
                    Price = 7599,
                    Image = "https://img.telemart.ua/622989-769063-category_page/msi-mag-1000w-pcie5-a1000gl.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 136,
                    Name = "Gigabyte P650SS 650W (GP-P650SS ICE) White",
                    Description = null,
                    Price = 2549,
                    Image = "https://img.telemart.ua/628002-775124-category_page/gigabyte-p650ss-650w-gp-p650ss-ice-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 137,
                    Name = "MSI MAG 1250W PCIE5 (A1250GL)",
                    Description = null,
                    Price = 9599,
                    Image = "https://img.telemart.ua/622988-836203-category_page/msi-mag-1250w-pcie5-a1250gl.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 138,
                    Name = "Corsair RM750x Shift 750W (CP-9020273-EU) White",
                    Description = null,
                    Price = 8028,
                    Image = "https://img.telemart.ua/618655-764296-category_page/corsair-rm750x-shift-750w-cp-9020273-eu-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 139,
                    Name = "Gigabyte UD1300GM PG5 1300W (GP-UD1300GM PG5)",
                    Description = null,
                    Price = 9999,
                    Image = "https://img.telemart.ua/500607-661741-category_page/gigabyte-ud1300gm-pg5-1300w-gp-ud1300gm-pg5.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 140,
                    Name = "Thermalright SP-850 850W (TR-SP850) Black",
                    Description = null,
                    Price = 5899,
                    Image = "https://img.telemart.ua/781034-1067643-category_page/thermalright-sp-850-850w-tr-sp850-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 7
                },
                new ProductModel()
                {
                    Id = 141,
                    Name = "SAMA 3307 140mm без БЖ Black",
                    Description = null,
                    Price = 2099,
                    Image = "https://img.telemart.ua/774302-1003984-category_page/sama-3307-140mm-bez-bp-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 142,
                    Name = "MSI MAG FORGE M100R без БЖ Black",
                    Description = null,
                    Price = 2499,
                    Image = "https://img.telemart.ua/457790-596348-category_page/msi-mag-forge-m100r-bez-bp-black.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 143,
                    Name = "SAMA 3307 140mm без БЖ White",
                    Description = null,
                    Price = 2149,
                    Image = "https://img.telemart.ua/775667-1004296-category_page/sama-3307-140mm-bez-bp-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 144,
                    Name = "SAMA V40 без БЖ (V40-BKADA6X1-GL) Black",
                    Description = null,
                    Price = 2799,
                    Image = "https://img.telemart.ua/793605-1002413-category_page/sama-v40-bez-bp-v40-bkada6x1-gl-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 145,
                    Name = "SAMA V40E без БЖ (V40E-BKAD00X1-RU) Black",
                    Description = null,
                    Price = 1899,
                    Image = "https://img.telemart.ua/793607-1073568-category_page/sama-v40e-bez-bp-v40e-bkad00x1-ru-black.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 146,
                    Name = "APNX Creator C1 без БЖ (APCM-CR01043.21) White",
                    Description = null,
                    Price = 4999,
                    Image = "https://img.telemart.ua/577056-724081-category_page/aerocool-apnx-creator-c1-bez-bp-apcm-cr0104321-white.png",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 147,
                    Name = "Montech Air 100 ARGB без БЖ Black",
                    Description = null,
                    Price = 2479,
                    Image = "https://img.telemart.ua/547155-695956-category_page/montech-air-100-argb-bez-bp-black.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 148,
                    Name = "SAMA 3307 без БЖ Black",
                    Description = null,
                    Price = 1949,
                    Image = "https://img.telemart.ua/679129-918787-category_page/sama-3307-bez-bp-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 149,
                    Name = "PCCooler K101 Mesh 3F без БЖ Grey",
                    Description = null,
                    Price = 4899,
                    Image = "https://img.telemart.ua/773502-969109-category_page/pccooler-k101-mesh-3f-bez-bp-grey.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 150,
                    Name = "SAMA V60 без БЖ (V60-BKADA7X1-GL) Black",
                    Description = null,
                    Price = 3699,
                    Image = "https://img.telemart.ua/793610-1002471-category_page/sama-v60-bez-bp-v60-bkada7x1-gl-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 151,
                    Name = "Thermalright TL-M10 Vision без БЖ Black",
                    Description = null,
                    Price = 3949,
                    Image = "https://img.telemart.ua/780957-999425-category_page/thermalright-tl-m10-vision-bez-bp-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 152,
                    Name = "SAMA Neview 2851M без БЖ White",
                    Description = null,
                    Price = 3199,
                    Image = "https://img.telemart.ua/679100-912367-category_page/sama-neview-2851m-bez-bp-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 153,
                    Name = "SAMA 4502 без БЖ White",
                    Description = null,
                    Price = 4099,
                    Image = "https://img.telemart.ua/742738-919351-category_page/sama-4501-bez-bp-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 154,
                    Name = "GAMEMAX T20 Tempered Glass без БЖ White",
                    Description = null,
                    Price = 2899,
                    Image = "https://img.telemart.ua/813822-1041755-category_page/gamemax-t20-tempered-glass-bez-bp-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 155,
                    Name = "Gigabyte C201 Panoramic Tempered Glass без БЖ (GB-C201P) Black",
                    Description = null,
                    Price = 3799,
                    Image = "https://img.telemart.ua/745029-920109-category_page/gigabyte-c201-panoramic-tempered-glass-bez-bp-gb-c201p-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 156,
                    Name = "Cougar Duoface RGB Tempered Glass без БЖ Black",
                    Description = null,
                    Price = 3399,
                    Image = "https://img.telemart.ua/492541-1078446-category_page/cougar-duoface-rgb-tempered-glass-bez-bp-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 157,
                    Name = "GAMEMAX T20 Tempered Glass без БЖ Black",
                    Description = null,
                    Price = 2899,
                    Image = "https://img.telemart.ua/813821-1041741-category_page/gamemax-t20-tempered-glass-bez-bp-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 158,
                    Name = "Cougar FV150 RGB без БЖ White",
                    Description = null,
                    Price = 4399,
                    Image = "https://img.telemart.ua/691111-855421-category_page/cougar-fv150-rgb-bez-bp-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 159,
                    Name = "Asus ROG Strix Helios II GX601S Hatsune Miku Edition Tempered Glass без БЖ (90DC00W0-B39010) Green",
                    Description = null,
                    Price = 23499,
                    Image = "https://img.telemart.ua/816995-1045760-category_page/asus-rog-strix-helios-ii-gx601s-hatsune-miku-edition-tempered-glass-bez-bp-90dc00w0-b39010-green.jpg",
                    Amount = 0,
                    Color = null,
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 160,
                    Name = "SAMA M203 без БЖ Black",
                    Description = null,
                    Price = 1899,
                    Image = "https://img.telemart.ua/679123-912313-category_page/sama-m203-bez-bp-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 8
                },
                new ProductModel()
                {
                    Id = 161,
                    Name = "ID-Cooling SE-224-XTS BLACK (SE-224-XTS BLACK)",
                    Description = null,
                    Price = 1049,
                    Image = "https://img.telemart.ua/489265-629246-category_page/id-cooling-se-224-xts-black-se-224-xts-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 162,
                    Name = "Deepcool AG400 ARGB (R-AG400-BKANMC-G-2) Black",
                    Description = null,
                    Price = 1569,
                    Image = "https://img.telemart.ua/439531-583098-category_page/deepcool-ag400-argb-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 163,
                    Name = "ID-Cooling Frozn A400 (FROZN A400 Black)",
                    Description = null,
                    Price = 929,
                    Image = "https://img.telemart.ua/598716-740728-category_page/id-cooling-frozn-a400-frozn-a400-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 164,
                    Name = "APNX AP1 (APTC-PF30517.21) White",
                    Description = null,
                    Price = 1999,
                    Image = "https://img.telemart.ua/578964-725102-category_page/aerocool-apnx-ap1-aptc-pf3051721-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 165,
                    Name = "SAMA A40L (A40-XXWAYXOX-G) Black/Silver",
                    Description = null,
                    Price = 1049,
                    Image = "https://img.telemart.ua/793652-1003001-category_page/sama-a40l-a40-xxwayxox-g-blacksilver.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 166,
                    Name = "SAMA A40E (A40-XXWNNXOX-G) Black/Silver",
                    Description = null,
                    Price = 999,
                    Image = "https://img.telemart.ua/793651-1002982-category_page/sama-a40e-a40-xxwnnxox-g-blacksilver.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 167,
                    Name = "SAMA A40 (A40-BKWNNXOX-G) Black",
                    Description = null,
                    Price = 1099,
                    Image = "https://img.telemart.ua/793650-1002966-category_page/sama-a40-a40-bkwnnxox-g-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 168,
                    Name = "Arctic Freezer 36 (ACFRE00121A)",
                    Description = null,
                    Price = 1749,
                    Image = "https://img.telemart.ua/601260-758070-category_page/arctic-freezer-36-acfre00121a.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 169,
                    Name = "Thermalright Assassin X 120 V2",
                    Description = null,
                    Price = 1149,
                    Image = "https://img.telemart.ua/762011-950293-category_page/thermalright-assassin-x-120-v2.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 170,
                    Name = "SAMA X40L (X40-XXWAYXOX-G) Black/Silver",
                    Description = null,
                    Price = 899,
                    Image = "https://img.telemart.ua/793654-1003193-category_page/sama-x40l-x40-xxwayxox-g-blacksilver.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 171,
                    Name = "Zalman CNPS9X Performa Plus Black",
                    Description = null,
                    Price = 1369,
                    Image = "https://img.telemart.ua/725685-893568-category_page/zalman-cnps9x-performa-plus-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 172,
                    Name = "Thermalright Burst Assassin 120 Vision Black",
                    Description = null,
                    Price = 2749,
                    Image = "https://img.telemart.ua/762037-951454-category_page/thermalright-burst-assassin-120-vision-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 173,
                    Name = "Zalman CNPS9X Performa ARGB White",
                    Description = null,
                    Price = 1529,
                    Image = "https://img.telemart.ua/494061-633429-category_page/zalman-cnps9x-performa-argb-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 174,
                    Name = "ID-Cooling FROZN A620 PRO SE (FROZN A620 PRO SE)",
                    Description = null,
                    Price = 2199,
                    Image = "https://img.telemart.ua/709035-877936-category_page/id-cooling-frozn-a620-pro-se-frozn-a620-pro-se.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 175,
                    Name = "SAMA X30 (X30-BKWNYXOX-G) Black",
                    Description = null,
                    Price = 759,
                    Image = "https://img.telemart.ua/793655-1003182-category_page/sama-x30-x30-bkwnyxox-g-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 176,
                    Name = "ID-Cooling FROZN A620 GDL (FROZN A620 GDL)",
                    Description = null,
                    Price = 2899,
                    Image = "https://img.telemart.ua/711290-878977-category_page/id-cooling-frozn-a620-gdl-frozn-a620-gdl.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 177,
                    Name = "Thermalright Assassin King 120 SE",
                    Description = null,
                    Price = 999,
                    Image = "https://img.telemart.ua/762006-950108-category_page/thermalright-assassin-king-120-se.jpg",
                    Amount = 0,
                    Color = "Сірий",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 178,
                    Name = "SAMA X20 (X20-XXWNYXOX-G) Black/Silver",
                    Description = null,
                    Price = 589,
                    Image = "https://img.telemart.ua/793657-1017318-category_page/sama-x20-x20-xxwnyxox-g-blacksilver.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 179,
                    Name = "SAMA L4P120 White",
                    Description = null,
                    Price = 999,
                    Image = "https://img.telemart.ua/679160-912057-category_page/sama-l4p120-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 180,
                    Name = "MSI MAG COREFROZR AA13 Black",
                    Description = null,
                    Price = 1399,
                    Image = "https://img.telemart.ua/801784-1013835-category_page/msi-mag-corefrozr-aa13-black.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 9
                },
                new ProductModel()
                {
                    Id = 181,
                    Name = "Arctic Liquid Freezer III Pro 360 (ACFRE00180A) Black",
                    Description = null,
                    Price = 5599,
                    Image = "https://img.telemart.ua/755364-938252-category_page/arctic-liquid-freezer-iii-pro-360-acfre00180a-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 182,
                    Name = "Arctic Liquid Freezer III Pro 360 A-RGB (ACFRE00184A) Black",
                    Description = null,
                    Price = 6199,
                    Image = "https://img.telemart.ua/755362-938267-category_page/arctic-liquid-freezer-iii-pro-360-a-rgb-acfre00184a-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 183,
                    Name = "MSI MAG CoreLiquid A13 360 Black",
                    Description = null,
                    Price = 3699,
                    Image = "https://img.telemart.ua/689914-854093-category_page/msi-mag-coreliquid-a13-360-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 184,
                    Name = "MSI MAG CoreLiquid A15 240 Black",
                    Description = null,
                    Price = 3799,
                    Image = "https://img.telemart.ua/725697-894630-category_page/msi-mag-coreliquid-a15-240-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 185,
                    Name = "Gigabyte AORUS WATERFORCE II 360",
                    Description = null,
                    Price = 5999,
                    Image = "https://img.telemart.ua/572118-719113-category_page/gigabyte-aorus-waterforce-ii-360.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 186,
                    Name = "Corsair iCUE H170i Elite Capellix XT (CW-9060071-WW)",
                    Description = null,
                    Price = 5199,
                    Image = "https://img.telemart.ua/491645-630654-category_page/corsair-icue-h170i-elite-capellix-xt-cw-9060071-ww.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 187,
                    Name = "Arctic Liquid Freezer III Pro 360 A-RGB (ACFRE00188A) White",
                    Description = null,
                    Price = 6599,
                    Image = "https://img.telemart.ua/755363-938283-category_page/arctic-liquid-freezer-iii-pro-360-a-rgb-acfre00188a-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 188,
                    Name = "Deepcool LT520 (R-LT520-WHAMNF-G-1) White",
                    Description = null,
                    Price = 3899,
                    Image = "https://img.telemart.ua/475496-629375-category_page/deepcool-lt520-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 189,
                    Name = "Gigabyte AORUS WATERFORCE II 360 ICE",
                    Description = null,
                    Price = 5999,
                    Image = "https://img.telemart.ua/572117-719118-category_page/gigabyte-aorus-waterforce-ii-360-ice.png",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 190,
                    Name = "SAMA SM360 Pro White",
                    Description = null,
                    Price = 5999,
                    Image = "https://img.telemart.ua/679174-917843-category_page/sama-sm360-pro-white.png",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 191,
                    Name = "MSI MEG CORELIQUID S360",
                    Description = null,
                    Price = 11999,
                    Image = "https://img.telemart.ua/389435-542125-category_page/msi-meg-coreliquid-s360.png",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 192,
                    Name = "SAMA SM240 Black",
                    Description = null,
                    Price = 4999,
                    Image = "https://img.telemart.ua/767278-991857-category_page/sama-sm240-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 193,
                    Name = "ID-Cooling DASHFLOW 360 XT",
                    Description = null,
                    Price = 5499,
                    Image = "https://img.telemart.ua/571645-719818-category_page/id-cooling-dashflow-360-xt-dashflow-360-xt.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 194,
                    Name = "SAMA SI360mm White",
                    Description = null,
                    Price = 3399,
                    Image = "https://img.telemart.ua/767283-991959-category_page/sama-si360mm-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 195,
                    Name = "Be Quiet! Light Loop 360mm (BW022) Black",
                    Description = null,
                    Price = 7299,
                    Image = "https://img.telemart.ua/678004-835790-category_page/be-quiet-light-loop-360mm-bw022-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 196,
                    Name = "Deepcool MYSTIQUE 360 (R-LX750-BKDSNMP-G-1) Black",
                    Description = null,
                    Price = 7779,
                    Image = "https://img.telemart.ua/629551-776073-category_page/deepcool-mystique-360-r-lx750-bkdsnmp-g-1-black.jpg",
                    Amount = 0,
                    Color = "Чорний",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 197,
                    Name = "Deepcool MYSTIQUE 240 (R-LX240-WHDSNMP-G-1) White",
                    Description = null,
                    Price = 7059,
                    Image = "https://img.telemart.ua/752614-934622-category_page/deepcool-mystique-240-r-lx240-whdsnmp-g-1-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 198,
                    Name = "MSI MAG CoreLiquid I360 White",
                    Description = null,
                    Price = 7199,
                    Image = "https://img.telemart.ua/641073-791155-category_page/msi-mag-coreliquid-i360-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 199,
                    Name = "MSI MAG CoreLiquid E240 White",
                    Description = null,
                    Price = 4999,
                    Image = "https://img.telemart.ua/549349-698079-category_page/msi-mag-coreliquid-e240-white.jpg",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 10
                },
                new ProductModel()
                {
                    Id = 200,
                    Name = "MSI MAG CoreLiquid I240 White",
                    Description = null,
                    Price = 5599,
                    Image = "https://img.telemart.ua/641075-791148-category_page/msi-mag-coreliquid-i240-white.png",
                    Amount = 0,
                    Color = "Білий",
                    CategoryId = 10
                }
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub
{
    public class SceneLibrary
    {
        public List<Book> ModernLiterature { get; set; }
        public List<Book> Classics { get; set; }
        public List<Book> Drama { get; set; }
        public List<Book> CrimeThriller { get; set; }
        public List<Book> AdventureAction { get; set; }
        public List<Book> Romance { get; set; }
        public List<Book> Horror { get; set; }
        public List<Book> Comedy { get; set; }
        public List<Book> ScienceFictionFantasy { get; set; }
        public List<Book> HistoricFiction { get; set; }
        public List<Book> MacedonianPoetry { get; set; }
        public List<Book> ForeignPoetry { get; set; }
        public List<Book> Travel { get; set; }
        public List<Book> SportFitness { get; set; }
        public List<Book> Cookbooks { get; set; }
        public List<Book> Economy { get; set; }
        public List<Book> SocialOther { get; set; }
        public List<Book> Medicine { get; set; }
        public List<Book> ScienceOther { get; set; }
        public List<Book> Music { get; set; }
        public List<Book> FilmStagecraft { get; set; }
        public List<Book> Architecture { get; set; }
        public List<Book> EncyclopediaLexicon { get; set; }
        public List<Book> JournalMagazine { get; set; }

        public SceneLibrary()
        {
            ModernLiterature = new List<Book>
            {
                new Book("", "Невидливиот живот на Еуридиси Гузмау", "Марта Батаља", "Современа литература", 1200.00, 10),
                new Book("", "Авел Санчез: Приказна за една страст", "Мигел Де Унамуно", "Современа литература", 1210.00, 9),
                new Book("", "Јама", "Александар Куприн", "Современа литература", 1220.00, 8),
                new Book("", "Ситни души", "Луис Коуперус", "Современа литература", 1230.00, 7),
                new Book("", "Книга", "Жозе Луиш Пејшото", "Современа литература", 1240.00, 6),
                new Book("", "Книга на празниците", "Марко Погачар", "Современа литература", 1250.00, 5),
                new Book("", "Црвените очи", "Миријам Леруа", "Современа литература", 1260.00, 4),
                new Book("", "Сиви пчели", "Андреј Курков", "Современа литература", 1270.00, 3),
                new Book("", "Шега", "Доменико Старноне", "Современа литература", 1280.00, 2),
                new Book("", "Солунска 28 - трет дел", "Неле Карајлиќ", "Современа литература", 1290.00, 1),
                new Book("", "Неранцула", "Панаит Истрати", "Современа литература", 1300.00, 10),
                new Book("", "Мелита", "Јосип Еуген Томиќ", "Современа литература", 1310.00, 9),
                new Book("", "Чувај се од сењската река", "Аугуст Шеноа", "Современа литература", 1320.00, 8),
                new Book("", "Марта", "Елиза Ожешкова", "Современа литература", 1330.00, 7),
                new Book("", "Мртви капитали", "Јосип Козарац", "Современа литература", 1340.00, 6),
                new Book("", "Пред светлото", "Вјенцеслав Новак", "Современа литература", 1350.00, 5),
                new Book("", "Бунтот на ангелите", "Анатол Франс", "Современа литература", 1360.00, 4),
                new Book("", "Татарска пустина", "Дино Буцати", "Современа литература", 1370.00, 3),
                new Book("", "Скала", "Евгенија Кузњецова", "Современа литература", 1380.00, 2),
                new Book("", "Градина", "Петра Дворжакова", "Современа литература", 1390.00, 1)
            };

            Classics = new List<Book>
            {
                new Book("", "Травничка хроника", "Иво Андриќ", "Класична литература", 1200.00, 10),
                new Book("", "Сонувачот", "Владислав Рејмонт", "Класична литература", 1210.00, 9),
                new Book("", "Бедни луѓе", "Фјодор Достоевски", "Класична литература", 1220.00, 8),
                new Book("", "Мизерна", "Халит Зија Ушаклигил", "Класична литература", 1230.00, 7),
                new Book("", "Избрани раскази", "Антон П. Чехов", "Класична литература", 1240.00, 6),
                new Book("", "Магла и месечевина", "Меша Селимовиќ", "Класична литература", 1250.00, 5),
                new Book("", "The Gift", "Vladimir Nabokov", "Класична литература", 1260.00, 4),
                new Book("", "Growing Up in the South", "Jones Suzanne", "Класична литература", 1270.00, 3),
                new Book("", "Дневникот на Сатаната", "Леонид Андрееев", "Класична литература", 1280.00, 2),
                new Book("", "Pride and Prejudice", "Jane Austen", "Класична литература", 1290.00, 1),
                new Book("", "Scottish Folk & Fairy Tales", "Allison Galbraith", "Класична литература", 1300.00, 10),
                new Book("", "Паѓаат старици", "Данил Хармс", "Класична литература", 1310.00, 9),
                new Book("", "Во регистратурата", "Анте Ковачевиќ", "Класична литература", 1320.00, 8),
                new Book("", "Бегство во Будим", "Владислав Ванчура", "Класична литература", 1330.00, 7),
                new Book("", "Женското царство", "Антон Павлович Чехов", "Класична литература", 1340.00, 6),
                new Book("", "Среќното момче", "Бјернстјерне Бјернсон", "Класична литература", 1350.00, 5),
                new Book("", "Двобој", "Антон Павлович Чехов", "Класична литература", 1360.00, 4),
                new Book("", "Куќата на калинките", "Оскар Вајлд", "Класична литература", 1370.00, 3),
                new Book("", "Години на невиност", "Идит Вортон", "Класична литература", 1380.00, 2),
                new Book("", "Љубовта на последниот магнат", "Скот Фицџералд", "Класична литература", 1390.00, 1)
            };

            Drama = new List<Book>
            {
                new Book("", "Four Plays", "Copi", "Драма", 1400.00, 10),
                new Book("", "Раски и маски", "Александар Кујунџиски", "Драма", 1410.00, 9),
                new Book("", "Животот на Прача Рузвелт ; Невиност", "Деа Лоер", "Драма", 1420.00, 8),
                new Book("", "Медеја", "Лукиј Анај Сенека", "Драма", 1430.00, 7),
                new Book("", "Трилогија за непослушноста", "Ивана Сајко", "Драма", 1440.00, 6),
                new Book("", "Избрани драми - том 2", "Горан Стефановски", "Драма", 1450.00, 5),
                new Book("", "Нова античка драма", "Сашо Димовски", "Драма", 1460.00, 4),
                new Book("", "Жак и неговиот господар", "Милан Кундера", "Драма", 1470.00, 3),
                new Book("", "Слана и Јазол", "Душко Трифуновски", "Драма", 1480.00, 2),
                new Book("", "Невидливите", "Тена Штивичиќ", "Драма", 1490.00, 1),
                new Book("", "Henry IV, Part 2", "William Shakespeare", "Драма", 1500.00, 10),
                new Book("", "Мир-Божица-Ејрене", "Аристофан", "Драма", 1510.00, 9),
                new Book("", "Избрани драми", "Горан Стефановски", "Драма", 1520.00, 8),
                new Book("", "Plays : The Cherry Orchard, Three Sisters, The Seagull and Uncle Vanya", "Anton Chekhov", "Драма", 1530.00, 7),
                new Book("", "Henry IV, Part I", "William Shakespeare", "Драма", 1540.00, 6),
                new Book("", "Love's Labour's Lost", "William Shakespeare", "Драма", 1550.00, 5),
                new Book("", "Coriolanus", "William Shakespeare", "Драма", 1560.00, 4),
                new Book("", "The Merry Wives Of Windsor", "William Shakespeare", "Драма", 1570.00, 3),
                new Book("", "Richard II (Signet Classics)", "William Shakespeare", "Драма", 1580.00, 2),
                new Book("", "Julius Caesar", "William Shakespeare", "Драма", 1590.00, 1)
            };

            CrimeThriller = new List<Book>
            {
                new Book("", "Ехо на споделеното лудило", "Благоја Стојков", "Криминале", 1200.00, 10),
                new Book("", "Верувај ми", "Андерс Рослунд", "Криминале", 1210.00, 9),
                new Book("", "Само таа остана", "Рајли Сејгер", "Криминале", 1220.00, 8),
                new Book("", "Плен", "Ирса Сигурдадотир", "Криминале", 1230.00, 7),
                new Book("", "Жените", "Кристин Хана", "Криминале", 1240.00, 6),
                new Book("", "Плејлиста", "Себастија Фитцек", "Криминале", 1250.00, 5),
                new Book("", "Добра и лоша", "Алиса Фини", "Криминале", 1260.00, 4),
                new Book("", "Сестра смрт", "Даниел Петр", "Криминале", 1270.00, 3),
                new Book("", "Suspects", "Lesley Pearse", "Криминале", 1280.00, 2),
                new Book("", "X.Y.Z.", "Ана Кетрин Грин", "Криминале", 1290.00, 1),
                new Book("", "Елена знае", "Клаудија Пињеиро", "Криминале", 1300.00, 10),
                new Book("", "Играта на господин Филип", "Санта Аргирова", "Криминале", 1310.00, 9),
                new Book("", "Оддел Д", "Фрида Мекфаден", "Криминале", 1320.00, 8),
                new Book("", "Семејни тајни", "Лијан Моријарти", "Криминале", 1330.00, 7),
                new Book("", "Local Woman Missing", "Mary Kubica", "Криминале", 1340.00, 6),
                new Book("", "Camino Island", "John Grisham", "Криминале", 1350.00, 5),
                new Book("", "Rogue Lawyer", "John Grisham", "Криминале", 1360.00, 4),
                new Book("", "The Lost Symbol", "Dan Brown", "Криминале", 1370.00, 3),
                new Book("", "Dead Letters", "Caite Dolan-Leach", "Криминале", 1380.00, 2),
                new Book("", "The Associate", "John Grisham", "Криминале", 1390.00, 1)
            };

            AdventureAction = new List<Book>
            {
                new Book("", "Карбид", "Андриј Љубка", "Авантура", 1400.00, 10),
                new Book("", "Остров на тишината", "Весела Богданович", "Авантура", 1410.00, 9),
                new Book("", "Tarzan of the Apes", "Edgar Rice Burroughs", "Авантура", 1420.00, 8),
                new Book("", "Мировна машина", "Озгур Мумџу", "Авантура", 1430.00, 7),
                new Book("", "Нулорог", "Петр Станчик", "Авантура", 1440.00, 6),
                new Book("", "Сосед од пеколот 2: Совршенство", "Р.Л. Метјусон", "Авантура", 1450.00, 5),
                new Book("", "The Afghan", "Frederick Forsyth", "Авантура", 1460.00, 4),
                new Book("", "Пловејќи на Еџ", "Лесли Страт", "Авантура", 1470.00, 3),
                new Book("", "Merde Happens", "Stephen Clarke", "Авантура", 1480.00, 2),
                new Book("", "A Sparrow Falls", "Wilbur Smith", "Авантура", 1490.00, 1),
                new Book("", "Dangerous Minds", "Janet Evanovich", "Авантура", 1500.00, 10),
                new Book("", "Dragon Teeth", "Michael Crichton", "Авантура", 1510.00, 9)
            };

            Romance = new List<Book>
            {
                new Book("", "Безобразни писма", "Вај Киленд и Пенелопи Вард", "Романса", 1200.00, 10),
                new Book("", "Heart Bones", "Colleen Hoover", "Романса", 1210.00, 9),
                new Book("", "Point of Retreat", "Colleen Hoover", "Романса", 1220.00, 8),
                new Book("", "Hopeless", "Colleen Hoover", "Романса", 1230.00, 7),
                new Book("", "This Girl", "Colleen Hoover", "Романса", 1240.00, 6),
                new Book("", "Without Merit", "Colleen Hoover", "Романса", 1250.00, 5),
                new Book("", "Украдената убавина", "Кејт Мичел", "Романса", 1260.00, 4),
                new Book("", "Погрешно време за љубов", "Ина Мур", "Романса", 1270.00, 3),
                new Book("", "Забранети задоволства", "Елизабет Хојт", "Романса", 1280.00, 2),
                new Book("", "Кралицата Шарлота", "Џулија Квин", "Романса", 1290.00, 1),
                new Book("", "Скрши го мразот", "Хана Грејс", "Романса", 1300.00, 10),
                new Book("", "Девојката од прозорецот", "Ѓулсерен Будајџоглу", "Романса", 1310.00, 9),
                new Book("", "Опасни намери", "Елизабет Хојт", "Романса", 1320.00, 8),
                new Book("", "Шепотот на дневникот", "Ангела Пенова", "Романса", 1330.00, 7),
                new Book("", "Последиците од љубовта", "Сулејман Адонија", "Романса", 1340.00, 6),
                new Book("", "The Paris Apartment", "Lucy Foley", "Романса", 1350.00, 5),
                new Book("", "Сицилијанска романса", "Ен Редклиф", "Романса", 1360.00, 4),
                new Book("", "Горчливиот вкус на успехот", "Милијана Павловска", "Романса", 1370.00, 3),
                new Book("", "Сите недовршени нешта", "Ребека Јарос", "Романса", 1380.00, 2),
                new Book("", "Плејбој", "Вај Киленд", "Романса", 1390.00, 1)
            };

            Horror = new List<Book>
            {
                new Book("", "На планините на лудилото", "Х. Ф. Лавкрафт", "Хорор", 1400.00, 10),
                new Book("", "Се што правиме во мракот", "Џенифер Хилер", "Хорор", 1410.00, 9),
                new Book("", "Endymion (Hyperion)", "Dan Simmons", "Хорор", 1420.00, 8),
                new Book("", "The Rise of Endymion", "Dan Simmons", "Хорор", 1430.00, 7),
                new Book("", "Black House", "Stephen King", "Хорор", 1440.00, 6),
                new Book("", "The Girl Who Loved Tom Gordon", "Stephen King", "Хорор", 1450.00, 5),
                new Book("", "The Final Girl Support Group", "Grady Hendrix", "Хорор", 1460.00, 4),
                new Book("", "Things Have Gotten Worse Since We Last Spoke And Other Misfortunes", "Eric LaRocca", "Хорор", 1470.00, 3),
                new Book("", "Dolores Claiborne", "Stephen King", "Хорор", 1480.00, 2),
                new Book("", "Escaping From Houdini", "Kerri Maniscalco", "Хорор", 1490.00, 1),
                new Book("", "Dracula, A Mystery Story", "Bram Stoker", "Хорор", 1500.00, 10),
                new Book("", "Подоцна", "Стивен Кинг", "Хорор", 1510.00, 9),
                new Book("", "The Hunted", "Gabriel Bergmoser", "Хорор", 1520.00, 8),
                new Book("", "A Head Full of Ghosts", "Paul Tremblay", "Хорор", 1530.00, 7),
                new Book("", "Колку покрваво", "Стивен Кинг", "Хорор", 1540.00, 6),
                new Book("", "Flight or Fright : 17 Turbulent Tales", "Stephen King, Bev Vincent", "Хорор", 1550.00, 5),
                new Book("", "The Bazaar of Bad Dreams", "Stephen King", "Хорор", 1560.00, 4),
                new Book("", "Skeleton Crew", "Stephen King", "Хорор", 1570.00, 3),
                new Book("", "The Drawing Of The Three (The Dark Tower II)", "Stephen King", "Хорор", 1580.00, 2),
                new Book("", "Hearts in Atlantis", "Stephen King", "Хорор", 1590.00, 1)
            };

            Comedy = new List<Book>
            {
                new Book("", "I, Maybot: The Rise and Fall", "John Crace", "Комедија", 1200.00, 10),
                new Book("", "Најдобрите вицови на Окно 1-5", "", "Комедија", 1210.00, 9),
                new Book("", "Најдобрите вицови на Окно 5", "", "Комедија", 1220.00, 8),
                new Book("", "Најдобрите вицови на Окно 4", "", "Комедија", 1230.00, 7),
                new Book("", "Најдобрите вицови на Окно 3", "", "Комедија", 1240.00, 6),
                new Book("", "Најдобрите вицови на Окно 2", "", "Комедија", 1250.00, 5),
                new Book("", "Најдобрите вицови на Окно 1", "", "Комедија", 1260.00, 4),
                new Book("", "Цепај сине: пошто џабе живиш у Македонија", "Зоран Спасов - Ѕоф", "Комедија", 1270.00, 3),
                new Book("", "Џабе живиш у Скопје", "Зоран Спасов - Ѕоф", "Комедија", 1280.00, 2),
                new Book("", "Hark", "Sam Lipsyte", "Комедија", 1290.00, 1),
                new Book("", "Cold War Steve Presents... A Prat's Progress", "Cold War Steve", "Комедија", 1300.00, 10),
                new Book("", "Теодосиј Малиот", "Разван Радулеску", "Комедија", 1310.00, 9),
                new Book("", "Тошо Малерот - монологија", "Васко Тодоров", "Комедија", 1320.00, 8),
                new Book("", "Мрачни скршнувања", "Џон Ралстон Сол", "Комедија", 1330.00, 7),
                new Book("", "Confessions of a Forty-Something F**k Up", "Alexandra Potter", "Комедија", 1340.00, 6)
            };

            ScienceFictionFantasy = new List<Book>
            {
                new Book("", "Among Thieves", "M. J. Kuhn", "Научна фантастика и фантазија", 1400.00, 10),
                new Book("", "The Sentinel", "Lee Child", "Научна фантастика и фантазија", 1410.00, 9),
                new Book("", "The Desert Prince", "Peter V. Brett", "Научна фантастика и фантазија", 1420.00, 8),
                new Book("", "Harry Potter and the Deathly Hallows", "J.K. Rowling", "Научна фантастика и фантазија", 1430.00, 7),
                new Book("", "Anthem", "Ayn Rand", "Научна фантастика и фантазија", 1440.00, 6),
                new Book("", "Atlas Shrugged", "Ayn Rand", "Научна фантастика и фантазија", 1450.00, 5),
                new Book("", "The Lord Of The Rings", "J.R.R. Tolkien", "Научна фантастика и фантазија", 1460.00, 4),
                new Book("", "Detective Thrillers Short Stories (Gothic Fantasy)", "Lee Horsley", "Научна фантастика и фантазија", 1470.00, 3),
                new Book("", "Black Sci-Fi Short Stories (Gothic Fantasy)", "Tia Ross", "Научна фантастика и фантазија", 1480.00, 2),
                new Book("", "Fourth Wing", "Rebecca Yarros", "Научна фантастика и фантазија", 1490.00, 1),
                new Book("", "Witches, Wizards, Seers & Healers Myths & Tales: Epic Tales", "Diane Purkiss", "Научна фантастика и фантазија", 1500.00, 10),
                new Book("", "Силмарилион", "Џон Р. Р. Толкин", "Научна фантастика и фантазија", 1510.00, 9),
                new Book("", "The Return of the King", "J.R.R. Tolkien", "Научна фантастика и фантазија", 1520.00, 8),
                new Book("", "Time's Eye (A Time Odyssey)", "Arthur C. Clarke", "Научна фантастика и фантазија", 1530.00, 7),
                new Book("", "The Imperial Handbook - A Commander's Guide", "Daniel Wallace", "Научна фантастика и фантазија", 1540.00, 6),
                new Book("", "The Bounty Hunter Wars", "K W Jeter", "Научна фантастика и фантазија", 1550.00, 5),
                new Book("", "Inhibitor Phase", "Alastair Reynolds", "Научна фантастика и фантазија", 1560.00, 4),
                new Book("", "The Female Man", "Joanna Russ", "Научна фантастика и фантазија", 1570.00, 3),
                new Book("", "Grass (SF Masterworks)", "Sheri S. Tepper", "Научна фантастика и фантазија", 1580.00, 2)
            };

            HistoricFiction = new List<Book>
            {
                new Book("", "Залудно бегство", "Сигрун Паулсдотир", "Историска фикција", 1600.00, 10),
                new Book("", "Куќа на духови", "Изабел Аљенде", "Историска фикција", 1610.00, 9),
                new Book("", "A Long Petal of the Sea", "Isabel Allende", "Историска фикција", 1620.00, 8),
                new Book("", "Hamnet", "Maggie O Farrell", "Историска фикција", 1630.00, 7),
                new Book("", "Одмаздата на Тудорите", "К. В. Гортнер", "Историска фикција", 1640.00, 6),
                new Book("", "Фау-2", "Роберт Херис", "Историска фикција", 1650.00, 5),
                new Book("", "Олга и Лина", "Еуген Кумичиќ", "Историска фикција", 1660.00, 4),
                new Book("", "Империјата на сонцето", "Џ. Г. Балард", "Историска фикција", 1670.00, 3),
                new Book("", "Девојчински спомени", "Ани Ерно", "Историска фикција", 1680.00, 2),
                new Book("", "Пристанишна зона: приказна за духови", "Демјан Валфорд Дејвис", "Историска фикција", 1690.00, 1),
                new Book("", "Раскажувачот", "Мирана Ликар", "Историска фикција", 1700.00, 10),
                new Book("", "Зимската роза", "Мелани Добсон", "Историска фикција", 1710.00, 9),
                new Book("", "Shrines of Gaiety", "Kate Atkinson", "Историска фикција", 1720.00, 8),
                new Book("", "The Kingdoms", "Natasha Pulley", "Историска фикција", 1730.00, 7),
                new Book("", "The Marriage Portrait", "Maggie O'Farrell", "Историска фикција", 1740.00, 6),
                new Book("", "Lord John and the Hand of Devils", "Diana Gabaldon", "Историска фикција", 1750.00, 5),
                new Book("", "The Fortune Of War", "Patrick O'Brian", "Историска фикција", 1760.00, 4),
                new Book("", "The Library of the Dead", "T. L. Huchu", "Историска фикција", 1770.00, 3),
                new Book("", "The Wine-Dark Sea", "Patrick O'Brian", "Историска фикција", 1780.00, 2),
                new Book("", "The Surgeon's Mate", "Patrick O'Brian", "Историска фикција", 1790.00, 1)
            };

            MacedonianPoetry = new List<Book>
            {
                new Book("", "Јазикот што само ние го разбираме", "Зоран Јакимоски", "Македонска поезија", 1800.00, 10),
                new Book("", "Грозје од кукавица", "Славе Ѓорѓо Димоски", "Македонска поезија", 1810.00, 9),
                new Book("", "Шестарот на времето", "Никола Маџиров", "Македонска поезија", 1820.00, 8),
                new Book("", "Додека спиеш", "Биљана Стојановска", "Македонска поезија", 1830.00, 7),
                new Book("", "Меѓу копнежот и сонот", "Соња Карбева", "Македонска поезија", 1840.00, 6),
                new Book("", "Во твоите зеници", "Анита Димитриевска", "Македонска поезија", 1850.00, 5),
                new Book("", "Небо од стихови", "Софија Добревска", "Македонска поезија", 1860.00, 4),
                new Book("", "Една ноќ", "Кристина Краличин", "Македонска поезија", 1870.00, 3),
                new Book("", "Нејзина песна - Пет современи македонски поетеси", "", "Македонска поезија", 1880.00, 2),
                new Book("", "Подоцна", "Маријан Бошевски", "Македонска поезија", 1890.00, 1),
                new Book("", "Утре е секогаш сега", "Весна Алексова Стојковска", "Македонска поезија", 1900.00, 10),
                new Book("", "Дождови во мај: сублимирани емоции со две лажички мед", "Даница И. Лепојевиќ", "Македонска поезија", 1910.00, 9),
                new Book("", "Стражари на ноќта", "Марија Митева", "Македонска поезија", 1920.00, 8),
                new Book("", "Капки", "Ристо Маџунков", "Македонска поезија", 1930.00, 7),
                new Book("", "Ветар и магла", "Вера Лиличиќ", "Македонска поезија", 1940.00, 6),
                new Book("", "Љубовно аздисано хаику", "Стефчо Стефанов", "Македонска поезија", 1950.00, 5),
                new Book("", "Две мориња", "Јосип Коцев", "Македонска поезија", 1960.00, 4),
                new Book("", "Бесконечно: анатомија на страста", "Десанка Николова", "Македонска поезија", 1970.00, 3),
                new Book("", "Боја во сето сиво", "Александра Андреева", "Македонска поезија", 1980.00, 2),
                new Book("", "Филмски песни", "Дејан Трајкоски", "Македонска поезија", 1990.00, 1)
            };

            ForeignPoetry = new List<Book>
            {
                new Book("", "Selected Poetical Works: Blake", "William Blake", "Foreign Poetry", 1800.00, 10),
                new Book("", "Poems", "Charles Dickens", "Foreign Poetry", 1810.00, 9),
                new Book("", "Sonnets", "Cecco Angiolieri", "Foreign Poetry", 1820.00, 8),
                new Book("", "Poems from the high Prairie", "Alice Louise Wagoner , Anna Applegarth", "Foreign Poetry", 1830.00, 7),
                new Book("", "Spoon River Anthology: 100th Anniversary Edition", "Edgar Lee Masters", "Foreign Poetry", 1840.00, 6),
                new Book("", "Home Body", "Rupi Kaur", "Foreign Poetry", 1850.00, 5),
                new Book("", "RENDANG", "Will Harris", "Foreign Poetry", 1860.00, 4),
                new Book("", "Phenomenal Woman : Four Poems Celebrating Women", "Maya Angelou", "Foreign Poetry", 1870.00, 3),
                new Book("", "The Complete Poems of John Keats", "John Keats", "Foreign Poetry", 1880.00, 2),
                new Book("", "Mother : A Cradle to Hold Me", "Maya Angelou", "Foreign Poetry", 1890.00, 1),
                new Book("", "And Still I Rise : A Book of Poems", "Maya Angelou", "Foreign Poetry", 1900.00, 10),
                new Book("", "I Shall Not Be Moved : Poems", "Maya Angelou", "Foreign Poetry", 1910.00, 9),
                new Book("", "I Shall Not Be Moved", "Maya Angelou", "Foreign Poetry", 1920.00, 8),
                new Book("", "A Little Larger Than the Entire Universe : Selected Poems", "Fernando Pessoa", "Foreign Poetry", 1930.00, 7),
                new Book("", "The Song of Roland", "Guy Gavriel Kay", "Foreign Poetry", 1940.00, 6),
                new Book("", "The Colossus and Other Poems", "Sylvia Plath", "Foreign Poetry", 1950.00, 5),
                new Book("", "Betting on the Muse", "Charles Bukowski", "Foreign Poetry", 1960.00, 4),
                new Book("", "Rumi: Bridge to the Soul : Journeys into the Music and Silence of the Heart", "Rumi", "Foreign Poetry", 1970.00, 3),
                new Book("", "On Love", "Charles Bukowski", "Foreign Poetry", 1980.00, 2),
                new Book("", "Dangling in the Tournefortia", "Charles Bukowski", "Foreign Poetry", 1990.00, 1)
            };

            Travel = new List<Book>
            {
                new Book("", "Pretty Little London", "Sara Santini, Andrea Di Filipo", "Travel", 2020.00, 10),
                new Book("", "Birnbaum's 2020 Disneyland Resort: The Official Vacation Guide", "Birnbaum Guides", "Travel", 2021.00, 9),
                new Book("", "501 great places to stay", "Fid Backhouse, Arthur Findlay, Kieran Fogarty", "Travel", 2022.00, 8),
                new Book("", "Churches & monasteries : guide book", "Goce Drtkovski, Natali Nikolovska", "Travel", 2023.00, 7),
                new Book("", "Phuket (Marco Polo Guide)", "Академска Книга", "Travel", 2024.00, 6),
                new Book("", "Dubrovnik & Dalmatian Coast (Marco Polo Pocket Guide)", "Академска Книга", "Travel", 2025.00, 5),
                new Book("", "Prague (Marco Polo Travel Handbook)", "Академска Книга", "Travel", 2026.00, 4),
                new Book("", "Dubai (Marco Polo Pocket Guide)", "Академска Книга", "Travel", 2027.00, 3),
                new Book("", "Berlin (Marco Polo Travel Handbook)", "Академска Книга", "Travel", 2028.00, 2),
                new Book("", "Lisbon (Marco Polo Guide)", "Академска Книга", "Travel", 2029.00, 1),
                new Book("", "Venice (Marco Polo Pocket Guide)", "Академска Книга", "Travel", 2030.00, 10),
                new Book("", "Tenerife (Marco Polo Pocket Guide)", "Академска Книга", "Travel", 2031.00, 9),
                new Book("", "Cuba (Marco Polo Pocket Guide)", "Академска Книга", "Travel", 2032.00, 8),
                new Book("", "Ireland (Marco Polo Travel Handbook)", "Академска Книга", "Travel", 2033.00, 7),
                new Book("", "Rome (Marco Polo Travel Handbook)", "Академска Книга", "Travel", 2034.00, 6),
                new Book("", "Florence (Marco Polo Travel Handbook)", "Академска Книга", "Travel", 2035.00, 5),
                new Book("", "Dresden (Marco Polo Travel Handbook)", "Академска Книга", "Travel", 2036.00, 4),
                new Book("", "Insight Guides: Italian Lakes", "Академска Книга", "Travel", 2037.00, 3),
                new Book("", "Insight Guides: Brazil", "Академска Книга", "Travel", 2038.00, 2),
                new Book("", "Скопје: водич на улици", "Љубе Ристовски", "Travel", 2039.00, 1)
            };

            SportFitness = new List<Book>
            {
                new Book("", "Science of HIIT: Understand the Anatomy and Physiology to Transform Your Body", "Ingrid S. Clay", "Sport/Fitness", 2020.00, 10),
                new Book("", "Foam Roller Exercises : Relieve Pain, Prevent Injury, Improve Mobility", "Sam Woodworth", "Sport/Fitness", 2021.00, 9),
                new Book("", "15-Minute Gentle Yoga : Four 15-Minute Workouts for Energy, Balance, and Calm", "Louise Grime", "Sport/Fitness", 2022.00, 8),
                new Book("", "15-Minute Pilates : Four 15-Minute Workouts for Strength, Stretch, and Control", "Alycea Ungaro", "Sport/Fitness", 2023.00, 7),
                new Book("", "Основен тренинг за живот", "Марино Башиќ", "Sport/Fitness", 2024.00, 6),
                new Book("", "Football Leaks : Uncovering the Dirty Deals Behind the Beautiful Game", "Rafael Buschmann", "Sport/Fitness", 2025.00, 5),
                new Book("", "The Qigong Bible", "Katherine Allen", "Sport/Fitness", 2026.00, 4),
                new Book("", "15 Minute Fitness: 100 quick and easy exercises", "Suzanne Martin", "Sport/Fitness", 2027.00, 3),
                new Book("", "The Accumulator : The Revolutionary 30-Day Fitness Plan", "Paul Mumford", "Sport/Fitness", 2028.00, 2),
                new Book("", "Тренирање со руско ѕвоно", "Стив Котер", "Sport/Fitness", 2029.00, 1),
                new Book("", "Pilates for Living : Get stronger, fitter and healthier for an active later life", "Harri Angell", "Sport/Fitness", 2030.00, 10),
                new Book("", "A Little Course in Pilates : Simply Everything You Need to Succeed", "DK", "Sport/Fitness", 2031.00, 9),
                new Book("", "Издржи, кралице : реални приказни за растежот, падовите и успесите на еден брат и една сестра во свет во кој трчањето е помалку од ништо но повеќе од сè", "Весна Кираџиева, Александар Кираџиев", "Sport/Fitness", 2032.00, 8),
                new Book("", "Девијантност и социјална контрола во спортот", "Мајкл Еткинсон", "Sport/Fitness", 2033.00, 7),
                new Book("", "Менаџмент на човечки ресурси во спортот и рекреацијата", "Пакианатан Челадурај", "Sport/Fitness", 2034.00, 6),
                new Book("", "Психологија на физичката активност : детерминанти, добросостојба и интервенции", "Стјуарт Џ.Х. Бидл, Нанет Матри", "Sport/Fitness", 2035.00, 5),
                new Book("", "Напреден бокс : обука, вештини и техники", "Ракеш Сонди, Томи Томпсон", "Sport/Fitness", 2036.00, 4),
                new Book("", "Квалитативно истражување во физичката активност и во здравствените професии", "Вилијам Питни", "Sport/Fitness", 2037.00, 3),
                new Book("", "Како успешно да се игра ракомет: техника, тактика, тренинг", "Кристоф Колоџеј", "Sport/Fitness", 2038.00, 2),
                new Book("", "Основи на спортскиот менаџмент", "Роберт Бејкер, Крег Ешерик", "Sport/Fitness", 2039.00, 1)
            };

            Cookbooks = new List<Book>()
            {
                new Book("", "Enjoying Bourbon", "Frank Flannery", "Книги за готвење", 1590, 10),
                new Book("", "Tea at the Palace", "Carolyn Robb", "Книги за готвење", 1290, 9),
                new Book("", "Party Drinks", "Rebecca Hubbell", "Книги за готвење", 1390, 8),
                new Book("", "The Mix", "Liora Bels", "Книги за готвење", 1490, 7),
                new Book("", "The Great American Recipe Cookbook", "Академска Книга", "Книги за готвење", 1790, 6),
                new Book("", "200 Family Slow Cooker Recipes", "Sara Lewis", "Книги за готвење", 1690, 5),
                new Book("", "Australian Women's Weekly Healthy Eating : Balanced, Nourishing Everyday Recipes", "Академска Книга", "Книги за готвење", 1890, 4),
                new Book("", "Вегански готвач : со радост во кујната и љубов кон животните", "Срце за животните", "Книги за готвење", 1490, 3),
                new Book("", "Готвењето како наука и уметноста на убавото јадење", "Пелегрино Артузи", "Книги за готвење", 1590, 2),
                new Book("", "Modern Flexitarian : Veg-based Recipes you can Flex to add Fish, Meat, or Dairy", "DK", "Книги за готвење", 1690, 1),
                new Book("", "Australian Women's Weekly: Vegetarian - Flavoursome, Nutritious Everyday Recipes", "Australian Women'S Weekly", "Книги за готвење", 1790, 10),
                new Book("", "The Korean Vegan Cookbook : Reflections and Recipes from Omma's Kitchen", "Joanna Lee Molinaro", "Книги за готвење", 1990, 9),
                new Book("", "Plenty more : живописни зеленчукови рецепти за изобилство од вкусови", "Јотам Отоленги", "Книги за готвење", 1890, 8),
                new Book("", "Од длабочините на морето", "Дејан Карапеев", "Книги за готвење", 1690, 7),
                new Book("", "Dave's kitchen: Гответе насмеани", "Давор Панчевски", "Книги за готвење", 1590, 6),
                new Book("", "Mowgli Street Food : Stories and recipes from the Mowgli Street Food restaurants", "Nisha Katona", "Книги за готвење", 1790, 5),
                new Book("", "Голем готвач за бебиња и мали децa", "Dagmar Fon Kram", "Книги за готвење", 1490, 4),
                new Book("", "Моите најдобри рецепти", "Билјана Вучкова", "Книги за готвење", 1690, 3),
                new Book("", "The Frankies Spuntino Kitchen Companion & Cooking Manual", "The Frankies", "Книги за готвење", 1990, 2),
                new Book("", "The Slow Cooker Baby Food Cookbook", "Maggie Meade", "Книги за готвење", 1790, 1)
            };

            Economy = new List<Book>
            {
                new Book("", "Дигитална економија", "Зоран Јаневски", "Economy", 1200.00, 10),
                new Book("", "Вештини на вработените за конкурентност на мали и средни претпријатија", "д-р Ирина Пиперкова, д-р Александра Лозановска", "Economy", 930.00, 9),
                new Book("", "Можности за примена на концептот на зелена економија во мсп во РСМ", "Неда Петроска-Ангеловска, Катерина Хаџи Наумова-Михајловска", "Economy", 1390.00, 8),
                new Book("", "Квалитетот на живот на населението во РСМ во време на COVID-19 пандемијата", "д-р Владимир Петковски, д-р Исидора Станчева", "Economy", 995.00, 7),
                new Book("", "Демографско терминолошки речник", "Економски институт - Скопје", "Economy", 785.00, 6),
                new Book("", "Особености на активното и неактивното помладо население во Р. Македонија", "Верица Јаневска, Александра Лозаноска", "Economy", 650.00, 5),
                new Book("", "Финансирање на мали и средни претпријатија", "Биљана Ангелова, Климентина Попоска", "Economy", 1075.00, 4),
                new Book("", "Меѓународен маркетинг: концепциски, стратегиски и акциони аспекти", "Татјана Петковска Мирчевска", "Economy", 1245.00, 3),
                new Book("", "Научната дијаспора од Република Македонија", "Верица Јанеска (редактор)", "Economy", 840.00, 2),
                new Book("", "Претприемачка лабораторија", "Татјана П. Мирчевска, Зоран Јаневски", "Economy", 1495.00, 1),
                new Book("", "Акциите - инструмент на портфолио менаџментот", "Диана Бошковска", "Economy", 1100.00, 10),
                new Book("", "Претприемништво и електронска трговија", "Зоран Јаневски", "Economy", 875.00, 9),
                new Book("", "Готовинскиот тек и ликвидноста на претпријатијата", "Неда Петровска-Ангеловска", "Economy", 1300.00, 8),
                new Book("", "Примена на повеќекритериумски методи во банкарството : случајот на Комерцијална банка АД Скопје", "Виолета Цветковска", "Economy", 1020.00, 7),
                new Book("", "Туризмот и економскиот развој на Република Македонија", "Марија Ацковска", "Economy", 750.00, 6),
                new Book("", "Историја на економската мисла", "Агнард Сандму", "Economy", 1275.00, 5),
                new Book("", "Маркетинг-менаџмент : знаења и вештини", "Џ. Пол Питер, Џејмс Донели", "Economy", 945.00, 4),
                new Book("", "Претприемачки мал бизнис", "Џером Кац, Ричард Грин", "Economy", 1512.00, 3),
                new Book("", "Претприемаштво", "Robert Hisrih, Mihael Peters", "Economy", 975.00, 2),
                new Book("", "Стратегиски бренд-менаџмент : градење, мерење и управување со капиталот на брендот", "Кевин Лејн Келер", "Economy", 1400.00, 1)
            };

            SocialOther = new List<Book>()
            {
                new Book("", "Злоупотреба на процесните овластувања во парничната постапка", "Милка Ракочевиќ", "Правни науки", 1250, 10),
                new Book("", "Loyalty towards the constitution : dissenting opinions of judge Darko Kostadinovski, ph.d.", "Darko Kostadinovski Ph.D", "Правни науки", 1750, 9),
                new Book("", "Лојалност кон уставот", "Дарко Костадиновски", "Правни науки", 1450, 8),
                new Book("", "Македонско енергетско право", "Серјожа Марков, Јован Андоновски", "Правни науки", 1980, 7),
                new Book("", "Уставно право", "Светомир Шкариќ", "Правни науки", 1320, 6),
                new Book("", "Криминолошки профил на сторителите на кривичното дело силување", "Крсте Маљановски", "Правни науки", 1670, 5),
                new Book("", "Човекови права и психоанализа", "Љубомир Д. Фрчковски", "Правни науки", 1540, 4),
                new Book("", "Воспоставување на единствен државен протокол на ниво на Република Македонија", "Санде Симијанов", "Правни науки", 1790, 3),
                new Book("", "Реторика", "Јован Андоновски", "Правни науки", 1360, 2),
                new Book("", "Ники", "Тибор Дери", "Правни науки", 1420, 1),
                new Book("", "Судска психологија со психопатологија", "Д-р Крсте Маљановски", "Правни науки", 1630, 10),
                new Book("", "Шизофренија или аскетизам", "Јован Корнаракис", "Правни науки", 1550, 9),
                new Book("", "Децата и разводот", "Драгана Батиќ", "Правни науки", 1480, 8)
            };

            Medicine = new List<Book>()
            {
                new Book("", "Unnatural Causes", "Richard Shepherd", "Medicine", 2890, 10),
                new Book("", "Инспиративна вистина", "Орде Ѓорѓиоски", "Medicine", 2190, 9),
                new Book("", "Јуридизација на медицината – реален ст(р)ав за лекарска грешка", "Габриела Гајдова", "Medicine", 2490, 8),
                new Book("", "Микрохируршка ендодонција", "Арналдо Кастелучи", "Medicine", 3190, 7),
                new Book("", "Педијатриски прирачник : за првите шест години", "Ангелчо Андоновски, Татјана Јаќовска", "Medicine", 2690, 6),
                new Book("", "Некои аспекти на новоформираното коскено ткиво", "Ненад Атанасов, Виктор Камнар", "Medicine", 1990, 5),
                new Book("", "Акушерство : учебник", "Весна Антовска", "Medicine", 2990, 4),
                new Book("", "Невролошки терапевтски прирачник", "Методи Чепреганов, Милчо Демерџиев", "Medicine", 3490, 3),
                new Book("", "Атлас на човечката анатомија", "Френк Х. Нетер", "Medicine", 4190, 2),
                new Book("", "Медицински основи на инвалидноста", "Владимир Трајковски", "Medicine", 2590, 1),
                new Book("", "Одбрани поглавја од трансфузиона хематологија и интерна медицина", "Трајан Стрезоски", "Medicine", 2990, 10),
                new Book("", "Генетски предиспозиции за заразни заболувања", "Ричард Кезлоу", "Medicine", 2890, 9),
                new Book("", "Харперова илустрирана биохемија", "Роберт Мареј", "Medicine", 3290, 8)
            };

            ScienceOther = new List<Book>()
            {
                new Book("", "Special & General Relativity Concise Edition", "Алберт Ајнштајн", "Природни науки", 2890, 10),
                new Book("", "Габите во Македонија", "Санде Стојчевски", "Природни науки", 2190, 9),
                new Book("", "Анализа со конечни елементи", "Виктор Христовски", "Природни науки", 2490, 8),
                new Book("", "Изведба на објекти од високоградба", "Мадан Мета, Волтер Скарбороу, Дајен Армприст", "Природни науки", 3190, 7),
                new Book("", "The Road to Conscious Machines: The Story of AI", "Мајкл Вулдриџ", "Природни науки", 2690, 6),
                new Book("", "Модерна имплементација на компајлери во Java", "Ендрју Апел", "Природни науки", 1990, 5),
                new Book("", "Комплексност на пресметувањата : современ пристап", "Санџив Арора", "Природни науки", 2990, 4),
                new Book("", "Карти - Погоди ја земјата", "Топер", "Природни науки", 2490, 3),
                new Book("", "Matematika : doracak për parashkollorë : 4-5 vjet", "Билјана Стојоска-Златков", "Природни науки", 2190, 2),
                new Book("", "Kujtesa matematikore : doracak për moshën parashkollore : (5 - 6 vjeç)", "Ели Маказлиева", "Природни науки", 1890, 1),
                new Book("", "Kujtesa matematikore : doracak për moshën parashkollore : (4 - 5 vjeç)", "Ели Маказлиева", "Природни науки", 1990, 10)
            };

            Music = new List<Book>()
            {
                new Book("", "Партитури за оркестар на шест антологиски кореографии", "Коловски Марко, Илиевски Дарко", "Музика", 1490, 10),
                new Book("", "Пиеси за пијано 1: Барок и класика", "Снежана Атанасова Чадиковска", "Музика", 1290, 9),
                new Book("", "ПИЕСИ за пијано 3, Романтизам и импресионизам Кн.1", "Снежана Атанасова Чадиковска, Стојанчо Баковски", "Музика", 1390, 8),
                new Book("", "ПИЕСИ за пијано 2, Романтизам и импресионизам Кн.1", "Снежана Атанасова Чадиковска, Стојанчо Баковски", "Музика", 1340, 7)
            };

            FilmStagecraft = new List<Book>()
            {
                new Book("", "The Film Book: A Complete Guide", "Ronald Bergan", "Филмска уметност и сценографија", 1890, 10)
            };

            Architecture = new List<Book>()
            {
                new Book("", "Паметни материјали во архитектурата, внатрешната архитектура и дизајнот", "Аксел Ритер", "Архитектура", 2890, 10),
                new Book("", "Нов архитектонски атлас", "Франциско Асенсио", "Архитектура", 3190, 9),
                new Book("", "Конструирање архитектура : материјали, процеси, структури : прирачник", "Андреа Деплацес", "Архитектура", 2790, 8),
                new Book("", "Ентериери : вовед", "Карла Нилсон, Дејвид Тејлор", "Архитектура", 2490, 7),
                new Book("", "Историја на архитектурата : основи и ритуали", "Спиро Костоф", "Архитектура", 2990, 6),
                new Book("", "Земјена архитектура : од античка до модерна", "Вилијам Морган", "Архитектура", 2690, 5),
                new Book("", "Нојферт: Архитектонско проектирање", "Ернст Нојферт", "Архитектура", 2890, 4)
            };

            EncyclopediaLexicon = new List<Book>()
            {
                new Book("", "Plant Magick", "Jessica Hundley", "Енциклопедии и лексикони", 2390, 10),
                new Book("", "Cabinet of Natural Curiosities", "Taschen", "Енциклопедии и лексикони", 2990, 9),
                new Book("", "The Chemistry Book: Big Ideas Simply Explained", "DK", "Енциклопедии и лексикони", 2790, 8),
                new Book("", "Great Novels", "D.K. Publishing", "Енциклопедии и лексикони", 2590, 7),
                new Book("", "Politics Philosophy & Economics", "", "Енциклопедии и лексикони", 2190, 6),
                new Book("", "The Book of Palms", "Carl Friedrich Philipp von Martius", "Енциклопедии и лексикони", 2690, 5),
                new Book("", "Disney A to Z : The Official Encyclopedia", "Dave Smith", "Енциклопедии и лексикони", 2490, 4),
                new Book("", "The Science of Pregnancy : The Complete Illustrated Guide from Conception to Birth", "DK", "Енциклопедии и лексикони", 2890, 3),
                new Book("", "Star Wars Ultimate Factivity Collection", "DK", "Енциклопедии и лексикони", 1990, 2),
                new Book("", "Norse Myths", "Matt Ralphs", "Енциклопедии и лексикони", 2290, 1),
                new Book("", "Dinosaurs and Other Prehistoric Life", "Prof Anusuya Chinsamy-Turan", "Енциклопедии и лексикони", 2390, 10),
                new Book("", "Greek Myths : Meet the heroes, gods, and monsters of ancient Greece", "DK", "Енциклопедии и лексикони", 2190, 9),
                new Book("", "The Sherlock Holmes Book Big Ideas Simply Explained", "DK", "Енциклопедии и лексикони", 2590, 8),
                new Book("", "Star Wars: The Complete Visual Dictionary", "Pablo Hidalgo, DR David Reynolds", "Енциклопедии и лексикони", 2990, 7),
                new Book("", "The Art Book : Big Ideas Simply Explained", "DK", "Енциклопедии и лексикони", 2690, 6),
                new Book("", "Earth : The Definitive Visual Guide", "DK", "Енциклопедии и лексикони", 2790, 5),
                new Book("", "1001 Books You Must Read Before You Die", "Peter Boxall", "Енциклопедии и лексикони", 2490, 4),
                new Book("", "Преглед на класични автомобили", "Мајкл Горман", "Енциклопедии и лексикони", 2590, 3),
                new Book("", "The Science of Animals : Inside their Secret World", "DK", "Енциклопедии и лексикони", 2890, 2),
                new Book("", "Тие имаат збор за тоа : ненаметлив лексикон на непреводливи зборови и фрази", "Хауард Реинголд", "Енциклопедии и лексикони", 2990, 1)
            };

            JournalMagazine = new List<Book>()
            {
                new Book("", "Современост бр. 4, 2023 год.", "Современост", "Часописи и магазини", 1290, 10),
                new Book("", "Современост бр. 1, 2023 год.", "Современост", "Часописи и магазини", 1190, 9),
                new Book("", "Современост бр. 2, 2022 год.", "Стеван Марковски, Снежана Стојчевска", "Часописи и магазини", 1090, 8),
                new Book("", "Современост бр. 4, 2021 год.", "Стеван Марковски, Снежана Стојчевска", "Часописи и магазини", 990, 7),
                new Book("", "Современост бр. 1, 2022 год.", "Стеван Марковски, Снежана Стојчевска", "Часописи и магазини", 1090, 6),
                new Book("", "Современост бр. 4, 2022 год.", "Современост", "Часописи и магазини", 1190, 5),
                new Book("", "Деветка бр. 4", "Тони Атанасовски, Игор Јовчевски", "Часописи и магазини", 1490, 4),
                new Book("", "Деветка бр. 3", "Игор Јовчевски, Никола Темков, Димано", "Часописи и магазини", 1390, 3),
                new Book("", "Деветка бр. 2", "Игор Јовчевски, Никола Темков, Димано", "Часописи и магазини", 1290, 2),
                new Book("", "Јавач на комета", "Славко Јаневски", "Часописи и магазини", 990, 1)
            };
        }

        public List<Book> returnList(string genre)
        {
            switch (genre)
            {
                case "ModernLiterature":
                    return ModernLiterature.ToList();
                case "Classics":
                    return Classics.ToList();
                case "Drama":
                    return Drama.ToList();
                case "CrimeThriller":
                    return CrimeThriller.ToList();
                case "AdventureAction":
                    return AdventureAction.ToList();
                case "Romance":
                    return Romance.ToList();
                case "Horror":
                    return Horror.ToList();
                case "Comedy":
                    return Comedy.ToList();
                case "ScienceFictionFantasy":
                    return ScienceFictionFantasy.ToList();
                case "HistoricFiction":
                    return HistoricFiction.ToList();
                case "MacedonianPoetry":
                    return MacedonianPoetry.ToList();
                case "ForeignPoetry":
                    return ForeignPoetry.ToList();
                case "Travel":
                    return Travel.ToList();
                case "SportFitness":
                    return SportFitness.ToList();
                case "Cookbooks":
                    return Cookbooks.ToList();
                case "Economy":
                    return Economy.ToList();
                case "SocialOther":
                    return SocialOther.ToList();
                case "Medicine":
                    return Medicine.ToList();
                case "ScienceOther":
                    return ScienceOther.ToList();
                case "Music":
                    return Music.ToList();
                case "FilmStagecraft":
                    return FilmStagecraft.ToList();
                case "Architecture":
                    return Architecture.ToList();
                case "EncyclopediaLexicon":
                    return EncyclopediaLexicon.ToList();
                case "JournalMagazine":
                    return JournalMagazine.ToList();
                default:
                    return new List<Book>();
            }
        }
    }
}

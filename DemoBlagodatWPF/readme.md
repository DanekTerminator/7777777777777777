# AuthWindow
![image](https://user-images.githubusercontent.com/90379312/222964282-1c696467-e013-452a-a328-2fb414d65f8d.png)
# 1 bad attemp
![image](https://user-images.githubusercontent.com/90379312/222964305-e531980f-f15e-4261-bd13-8e26a6a5bafd.png)
# 2 bad attemp
![image](https://user-images.githubusercontent.com/90379312/222964320-0eb48b92-65a5-4fe3-af0c-c887b15c9217.png)
# 3 bad attemp - блокируется взаимодействие с интерфейсом, скрываются символы капчи
![image](https://user-images.githubusercontent.com/90379312/222964646-fe475c94-940e-40e8-beb1-8bff181b446b.png)
# После введения верной капчи эдементы управления становятся жоступными для взаимодействия
![image](https://user-images.githubusercontent.com/90379312/222964609-9f2e4a1b-6690-4c28-b05b-23fe30eacc13.png)

# Дополнительно был добавлен вход по нажатию кнопки "Enter"
XAML:
 xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
      xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
      xmlns:local="clr-namespace:WpfApp1"
      mc:Ignorable="d" 
      d:DesignHeight="450" d:DesignWidth="800"
      Title="AddEditPage" KeyDown="OnKeyDown" >
CS:
 private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Login(sender, e);
            }
        }

# Добавлена стартовая позиция окна - по центру
XAML:
Title="Blagodat" MinHeight="1000" Width="1000" Height="854.5" WindowStartupLocation="CenterScreen">

# Страница с клиентами, с кнопками сортировки, созданием отчётов, переключением страниц
![image](https://user-images.githubusercontent.com/90379312/222965262-f6a2ae66-30fe-4f1c-8d53-50b9ee5d8998.png)
# Переключение страниц 5\7 и 7\7
![image](https://user-images.githubusercontent.com/90379312/222965421-47fd7920-0016-4379-bc3f-836ad3f4098a.png)
![image](https://user-images.githubusercontent.com/90379312/222965520-b64c1430-126a-49b1-a533-000ac493ea2f.png)
# Печать 7й страницы
![image](https://user-images.githubusercontent.com/90379312/222965561-e1e353dd-1347-4f74-b735-f21d14d66979.png)
# Штрих код
![image](https://user-images.githubusercontent.com/90379312/222965604-18222889-a50f-445b-8d08-5ff832f39ef1.png)
![image](https://user-images.githubusercontent.com/90379312/222965684-4175236f-4f39-4469-9946-b8646bd1177c.png)
# ЛистВью поиск, фильтрация. Поиск "Кули"
![image](https://user-images.githubusercontent.com/90379312/222966061-209af0f9-752b-42d1-90a4-b34d1c71d954.png)
![image](https://user-images.githubusercontent.com/90379312/222966082-c3921bd3-bcb7-4065-8b5f-d15a1752ed5e.png)
# История входа отсортированная по последней дате
![image](https://user-images.githubusercontent.com/90379312/222966117-33717118-cab4-4e3f-a1ae-cdd44923f5e2.png)
# История заказов 
![image](https://user-images.githubusercontent.com/90379312/222966555-d0ff83d7-5c1f-4b94-aa64-cb68259c727c.png)

# Создание таблицы
![image](https://user-images.githubusercontent.com/90379312/222966532-0a888eb2-bac3-4565-844b-15f9f5fd054c.png)


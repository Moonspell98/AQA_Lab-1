# AQA_Lab-1

1. Создать 3-ёх водителей, присвоить им машины.  
Вывести в консоль список водителей, включающий в себя:
* Фамилия;
* Имя;
* Дата рождения;
* Дата выдачи удостоверения (не может быть раньше даты рождения и от 16-и лет);
* Номер удостоверения (GUID);
2. Осуществить возможность выбора водителя.
3. После выбора водителя, дать возможность выбрать и  просмотреть информацию из меню, включающего в себя:
* Технические характеристики о своей машине (или о машинах):
  + Марка;
  + Год;
  + Рабочий объем двигателя;
  + Расход топлива;
  + Максимальная скорость.
* Эксплуатационные характеристики:
  + Стаж вождения;
  + Расход бензина на километраж (предусмотреть ввод с консоли километров). 
  + Время, за которое пользователь может преодолеть данное расстояние при максимальной скорости.  

**Class Vehicle:**
  + Model
  + int Year
  + Owner
  + Engine

**Class Engine:**
  + Capacity
  + Power (лс)
  + FuelType
  + MaximumSpeed

**Class Person:**
  + FirstName
  + LastName
  + DateOfBirth
  + Driver (true, false)

**Class Driver:**
  + DateDriverLicense
  + ID number

**Car can be:**
1. Sport Car (Driving experience from 5 years)
2. Truck (bool isPricep)
3. Minivan (seatsCount)

Используйте [Bogus](https://github.com/bchavez/Bogus) для генерации фейковой информации.  
Следуйте Code Conventions.  
Постарайтесь избежать дублирования кода.  

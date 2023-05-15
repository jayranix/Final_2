using System;

namespace IdeaCampWater
{
    class Program
    {
        static void Main(string[] args) //1
        {
            Console.Write("Enter tank capacity (liters): ");
            double tankCapacity = double.Parse(Console.ReadLine());

            Console.Write("Enter average water consumption during break (liters): ");
            double avgBreakWater = double.Parse(Console.ReadLine());

            Console.Write("Enter water volume filled per refill (liters): ");
            double refillVolume = double.Parse(Console.ReadLine());

            Console.Write("Enter break time interval (minutes): ");
            int breakInterval = int.Parse(Console.ReadLine());

            Console.Write("Enter refill time interval (minutes): ");
            int refillInterval = int.Parse(Console.ReadLine());

            Console.Write("Enter number of refill cycles per day: ");
            int refillCycles = int.Parse(Console.ReadLine());

            double dailyBreakTime = 24 * 60 / breakInterval;
            double dailyWaterUsageDuringBreaks = dailyBreakTime * avgBreakWater;

            double dailyRefillTime = 24 * 60 / refillInterval;
            double dailyRefillWater = refillVolume * refillCycles;

            double totalWaterUsage = dailyWaterUsageDuringBreaks + dailyRefillWater;

            double remainingWater = tankCapacity - totalWaterUsage;

            Console.WriteLine("Total water usage per day: {0:F2} liters", totalWaterUsage);
            Console.WriteLine("Remaining water in tank: {0:F2} liters", remainingWater);

            Console.ReadLine();
        }
    }

    balance1 = float(input("Enter balance 1: ")) //2
balance2 = float(input("Enter balance 2: "))
balance3 = float(input("Enter balance 3: "))

while True:
    payment = float(input("Enter payment (or 0 to exit): "))
    if payment <= 0:
        break
        
    if payment <= balance1:
        balance1 -= payment
    elif payment <= balance1 + balance2:
        balance2 -= payment - balance1
        balance1 = 0
    elif payment <= balance1 + balance2 + balance3:
        balance3 -= payment - balance1 - balance2
        balance2 = balance1 = 0
    else:
        print(f"Payment of {payment} exceeds total balance")
        continue

    print(f"Balance 1: {balance1}, Balance 2: {balance2}, Balance 3: {balance3}")
    
print(f"Unpaid balance: {balance1+balance2+balance3}")
โปรแกรมจะรับค่ายอดเบ็ดเตล็ด 3 ยอดเริ่มต้น และรับค่ายอดชำระทีละค่าจนกว่าผู้ใช้จะกรอกค่าลบหรือศูนย์ โดยจะทำการหักยอดชำระออกจากยอดเบ็ดเตล็ดตามลำดับ ถ้ายอดเบ็ดเตล็ดยอดที่ 1 ไม่เพียงพอ จะหักออกจากยอดเบ็ดเตล็ดยอดที่ 2 แทน และถ้ายอดเบ็ดเตล็ดยอดที่ 2 ก็ไม่เพียงพอเช่นกัน จะหักออกจากยอดเบ็ดเตล็ดยอดที่ 3 แทน ถ้ายอดชำระมากกว่ายอดเบ็ดเตล็ดรวมทั้งสามยอด จะไม่ทำการหัก แต่แสดงข้อความว่าชำระเกินยอดเบ็ดเตล็ด และต้องให้กรอกยอดชำระใหม่อีกครั้ง โปรแกรมจะแสดงผลลัพธ์เป็นยอดเบ็ดเตล็ดคงเหลือของแต่ละยอดทุกครั้งที่มีการหักยอดชำระ และเมื่อผู






Regenerate response

}

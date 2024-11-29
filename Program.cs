using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lab8
{
internal class Program
{
    static void Main(string[] args)
    {

        Povtor:

        int count = 0, bal = 0, virno = 0;
        String  S;

        if (MessageBox.Show("Площа паралелогама обчислюється за формулою - S=a⋅h, де a — довжина сторони, а h — висота, проведена до цієї сторони ?", "Питання №1", 
                             MessageBoxButtons. YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            bal=bal+2;
            virno++;
        }
        else
            MessageBox. Show("Помилка! Формула площі паралелограма - S=a⋅h, де a — довжина сторони, а h — висота, проведена до цієї сторони", "Увага!",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            count ++;
        
        if (Interaction.InputBox ("Скільки градусів = сума суміжних кутів паралелограма ?", "Питання №2", "0") == "180")    
        {
            bal=bal +2;
            virno++;
        }
        else
            MessageBox. Show("Помилка! сума сіміжних кутів паралелограма = 180 градусів.", "Увага",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            count++;
        
        if (Interaction.InputBox ("Скільки градусів = кожен із кутів прямокутнка ?\n1 - 180 ?\n2 - 45 ?\n3 - 90\n введіть нмер правильної відповіді ? \n", "Питання №3", "0") == "90")    
        {
            bal=bal +2;
            virno++;
        }
        else
            MessageBox. Show("Помилка! кожен із кутів прямокутнка = 90 градусів.", "Увага!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            count++;
         if (MessageBox.Show(" Чи вірно що діагоналі ромба ділять його кути навпіл.?", "Питання №4", 
                             MessageBoxButtons. YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            bal=bal +2;
            virno++;
        }
        else
            MessageBox. Show("Помилка! Діагоналі ромба ділять його кути навпіл", "Увага!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            count++;
        
         if (MessageBox.Show(" Чи вірно що паралелограм, прямокутник, ромб та квадрат є чотирикутниками та мають властивість протилежних сторін, що є паралельними?", "Питання №5", 
                             MessageBoxButtons. YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            bal=bal +2;
            virno++;
        }
        else
            MessageBox. Show("Помилка! паралелограм, прямокутник, ромб та квадрат є чотирикутниками та мають властивість протилежних сторін, що є паралельними", "Увага!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            count++;

        switch (virno)
        {
             case 6:
                S = "відмінно";
                 break;
            case 5:
                S = "дуже добре";
                break;
            case 4:
                S = "добре";
                break;
            case 3:
                S = "задовільно";
                break;
            case 2:
                S = "незадовільно";
                break;
             case 1:
                S = "погано";
                break;
        default:
        S = "провал !!! немає жодної вірної відповіді!!!";
        break;
        }
        if (MessageBox.Show ($"Підсумок:\n Правильних відповідей: {virno.ToString()} з {count.ToString()}. \n Кількість набраних балів: {bal.ToString()} \n Ваш результат:  {S}\n Бажаєте тестуватися ще?", "Результати тестування", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
        goto Povtor;

    }
}    
}

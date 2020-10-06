namespace FPFS.lib
module games = 
    open System
    let guessTheNumber min max = 
            printf "Введите число от %d до %d: " min max
            let num = fun () -> Console.ReadLine()
            let rnd = Random().Next(min, max)
            let win x y = (x = y)
            let toInt (x : string) = Convert.ToInt32(x)
            while not (win rnd (toInt (num ()))) do
                printf "%s" "Вы не угадали! Попробуйте ещё раз."
                printf "Введите число от %d до %d: " min max
            printf "Вы выиграли!\n"
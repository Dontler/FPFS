namespace FPFS
    open System
    open FPFS.lib.games
    module Program =
        [<EntryPoint>]
        let main args =
            let invitation =
                printf "Добро пожаловать в меню.\n"
                let guess = fun () -> Console.ReadLine()
                while true do
                    printf "Выберите одну из опций: "
                    match (guess ()) with
                    | "1" -> guessTheNumber 1 10
                    | "0" -> exit 0
                    | _ -> printf "Некорректный ввод!"
            invitation
            0

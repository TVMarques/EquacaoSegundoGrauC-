        string resposta;

        do
        {
            Console.WriteLine("====EQUAÇÃO DE 2° GRAU====");
            Console.WriteLine("A equação é assim: Ax² + Bx + C = 0");

            // Entrada dos coeficientes
            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());

            // Mostrando a equação
            Console.WriteLine($"\nEquação: {a}x² + {b}x + {c} = 0");

            // Fórmula do Delta
            Console.WriteLine("Δ = B² - 4.A.C");

            // Calculando o Delta
            int delta = b * b - 4 * a * c;
            Console.WriteLine($"Δ = {b}² - 4.{a}.{c}");
            Console.WriteLine($"Δ = {delta}\n");

            // Verificando as raízes
            if (delta < 0)
            {
                Console.WriteLine("Não existem raízes reais.");
            }
            else if (delta == 0)
            {
                double x = -b / (2.0 * a);
                Console.WriteLine("Existe uma raiz real (raiz dupla).");
                Console.WriteLine($"x = {x:F1}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("Existem duas raízes reais:");
                Console.WriteLine($"X¹ = (-B + √Δ) / (2.A) = (-{b} + √{delta}) / (2.{a})");
                Console.WriteLine($"X¹ = {x1:F1}");
                Console.WriteLine($"X² = (-B - √Δ) / (2.A) = (-{b} - √{delta}) / (2.{a})");
                Console.WriteLine($"X² = {x2:F1}");
            }

            // Loop para validar a resposta do usuário
            while (true)
            {
                Console.Write("\nDeseja calcular outra equação? (S/N): ");
                resposta = Console.ReadLine().Trim().ToUpper();//Trim remove os espaços e toUpper deixa tudo maiúsculo.

                if (resposta == "S" || resposta == "N")
                    break;
                else
                    Console.WriteLine("Entrada inválida! Digite 'S' para sim ou 'N' para não.");
            }

            Console.WriteLine();

        } while (resposta == "S");

        Console.WriteLine("Fim do programa!");



#include <stdio.h>

int main() {
    int diasTrabalhados;
    float valorPorDia = 30.0;
    float salarioBruto, desconto, salarioLiquido;

    // Solicita ao usuário o número de dias trabalhados
    printf("Digite o número de dias trabalhados: ");
    scanf("%d", &diasTrabalhados);

    // Calcula o salário bruto
    salarioBruto = diasTrabalhados * valorPorDia;

    // Calcula o desconto de 8%
    desconto = salarioBruto * 0.08;

    // Calcula o salário líquido
    salarioLiquido = salarioBruto - desconto;

    // Exibe o resultado
    printf("O valor líquido a ser pago é: R$ %.2f\n", salarioLiquido);

    return 0;
}

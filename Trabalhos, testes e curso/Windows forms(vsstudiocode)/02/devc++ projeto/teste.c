#include <stdio.h>

int main() {
    int valor, i, soma;

    soma = 0;

    printf("Digite 10 valores:\n");

    for (i = 0; i < 10; i++) {
        printf("Digite um valor: ");
        scanf("%d", &valor);

        if (valor % 2 != 0) {
            soma += valor;
        }
    }

    printf("A soma dos números ímpares é: %d\n", soma);

    return 0;
}

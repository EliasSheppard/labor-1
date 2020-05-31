#include <iostream>
#include <stdio.h>
#include <iostream>
using namespace std;
int main()
{
    setlocale(0, "Rus");
	int length;
	int volume;
	int factorial[10] = { 1,2,6,24,120,720,5040,40320,362880,3628800 };
	int index;
	cout << "Введите длину куба целым числом : ";
	cin >> length;
	volume = length * length * length;
	cout << "Объем " << volume << endl;
	cout << "Какой факториал вы хотите? Введите его индекс : ";
	cin >> index;
	cout << "факториал[" << index << "] равен " << factorial[index] << endl;
	system("PAUSE");
}
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
	cout << "������� ����� ���� ����� ������ : ";
	cin >> length;
	volume = length * length * length;
	cout << "����� " << volume << endl;
	cout << "����� ��������� �� ������? ������� ��� ������ : ";
	cin >> index;
	cout << "���������[" << index << "] ����� " << factorial[index] << endl;
	system("PAUSE");
}
#include<iostream>
#include<ctime>

using namespace std;

int main()
{
	const int N = 100;
	int dobas[N];
	srand((unsigned)time(NULL));
	int i;


	for (i = 0; i < N; i++)
	{
		dobas[i] = rand() % 11 + 2;
		cout << dobas[i] << " ";
	}
	cout << endl;

	//átlag
	int osszeg = 0;
	for (i = 0; i < N; ++i)
	{
		osszeg += dobas[i];
	}
	cout << "Az atlag: " << (float)osszeg / i;

	//volt-e 12-es
	i = 0;
	while (i < 100 && dobas[i] != 12)
		++i;
	if (i <= 99)
		cout << "\nVolt 12-es.";
	else
		cout << "\nNem volt12-es.";

	//páratlan-páros

	int paratlanDb = 0;
	for (i = 0; i < N; ++i)
		if (dobas[i] % 2 != 0)
			++paratlanDb;

	cout << "\nA paratlan dobasok szama: " << paratlanDb << " A paros dobasok szama: " << N - paratlanDb;

	//melyik dobásból? darab
	int mdobas[11] = { 0 };
	for (i = 0; i < N; ++i)
	{
		mdobas[dobas[i] - 2]++;
	}
	for (i = 0; i < 11; i++)
	{
		cout << "\n A(z)" << i + 2 << "-es dobasok szama\t" << mdobas[i];
	}

	//legnagyobb
	int max = 0;
	for (i = 0; i < N; ++i)
	{
		if (dobas[max] < dobas[i])
			max = i;
	}
	cout << "\nA legmagyobb dobas sorszama: " << max + 1 << " erteke:" << dobas[max];

	// a legnagyob dobasok sorszamai
	int gyujto[N], gydb = 0;
	for (i = 0; i < N; i++)
		if(dobas[i]==dobas[max])
	{
			gyujto[gydb] = i;
			++gydb;
	}
	cout << "\n A legnagyobb dobasok sorszamai: ";
	for (i = 0; i < gydb; ++i)
		cout << gyujto[i] + 1 << " ";










	return 0;
}
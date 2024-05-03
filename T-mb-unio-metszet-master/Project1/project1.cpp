#include <iostream>

using namespace std;

int main()
{
	//const int N = 10, M = 5;
	////Adatbevitel

	//int A_tomb[N] = { 13, 28, 43, 37, 10, 5, 8, 99, 101, 2 };
	//int B_tomb[M] = { 6,43,37,10,88 };
	//int i, j, cdb = 0, C_tomb[N + M];

	////Tömbök kiiratása

	//for (i = 0; i < N; ++i)
	//	cout << A_tomb[i] << " ";
	//cout << endl << endl;

	//for (j = 0; j < M; ++j)
	//	cout << B_tomb[j] << " ";
	//cout << endl << endl;

	////Metszetképzés

	//for (i = 0; i < N; ++i)
	//{
	//	j = 0;
	//	while (j < M && A_tomb[i] != B_tomb[j])
	//		++j;
	//	if (j < M)
	//		C_tomb[cdb++] = A_tomb[i];
	//}

	////Metszet tömb kiiratása
	//cout << endl;
	//for (i = 0; i < cdb; ++i)
	//	cout << C_tomb[i] << " ";

	////Unióképzés
	//
	//for (i = 0; i < N; ++i)
	//	C_tomb[i] = A_tomb[i];

	//cdb = N;
	//for (j = 0; j < M; ++j)
	//{
	//	i = 0;
	//	while (i < N && A_tomb[i] != B_tomb[j])
	//		++i;

	//	if (i > N - 1)
	//		C_tomb[cdb++] = B_tomb[j];
	//}

	////Unio kiiratása

	//cout << endl;
	//for (i = 0; i < cdb; i++)
	//	cout << C_tomb[i] << " ";
	//	cout << endl << endl;

	const int N = 9, M = 6;

	int psz_a[N] = { 11, 13, 19, 37, 45, 77, 86, 88, 101 };
	int psz_b[M] = { 1 ,15, 77, 99, 100, 101 };
	int psz_ossz[N + M - 1];

	int i, j;
	for (i = 0; i < N; ++i)
		cout << psz_a[i] << " ";
	cout << endl << endl;

	for (j = 0; j < N; ++j)
		cout << psz_b[j] << " ";
	cout << endl << endl;
	
	i = 0; j = 0;
	int cdb = 0;
	
	while (i < N || j < M)
	{
		if (psz_b[j] > psz_a[i])
			psz_ossz[cdb++] = psz_a[i++];
		if (psz_a[i] > psz_b[j])
			psz_ossz[cdb++] = psz_b[j++];
		if (psz_a[i] == psz_b[j])
		{
			psz_ossz[cdb++] = psz_a[i++];
			j++;
		}

	}
	cout << endl;
	for (i = 0; i < cdb; ++i)
		cout << psz_ossz[i] << " ";
	



	



	return 0;
}
#include <iostream>
#include<string>
#include<vector>

using namespace std;

int main()
{
	//const int N = 10, M = 7, K = 17;
	//string A[N]= {"Kecskemet", "Szeged", "Pecs", "Baja", "Gyor", "Miskolc", "Vac", "Szeged", "Sopron", "Eger"};
	//string B[M] = { "Budapest", "Kecskemet", "Szeged", "Pecs", "Baja", "Esztergom", "Salgotarjan" };
	//string C[K];
	//int i = 0;
	//cout << "Az alabbi varosokban jart januarban: \n";
	//for (i = 0; i < N; ++i)
	//	cout << A[i] << " ";
	//cout << endl;

	//cout << endl << "Az alabbi varosokban jart februarban: \n";
	//for (i = 0; i < M; ++i)
	//	cout << B[i] << " ";
	//cout << endl << endl;

	////Mindkét hónapban látogatta (metszet)

	//int j = 0, cdb = 0;
	//for (i = 0; i < N; ++i)
	//{
	//	j = 0;
	//	while (j < M && A[i] != B[j])
	//		++j;

	//	if (j < M)
	//		C[cdb++] = A[i];
	//}

	//cout << "Az alabbi varosokban jart mindket honapban: \n";
	//for (i = 0; i < cdb; ++i)
	//	cout << C[i] << " ";
	//cout << endl;

	////Legalább az gyik hónapban látogatta (unió)

	//for (i = 0; i < N; ++i)
	//	C[i] = A[i];
	//cout << endl;

	//cdb = N;
	//for (j = 0; j < M; ++j)
	//{
	//	i = 0;
	//	while (i < N && A[i] != B[j])
	//		++i;

	//	if (i > N - 1)
	//		C[cdb++] = B[j];
	//}
	//
	//cout << "Az alabbi varosokban jart legalabb az egyik honapban: \n";
	//for (i = 0; i < cdb; ++i)
	//	cout << C[i] << " ";
	//cout << endl;

	//--------------------------------------------------------------------------------------------------------------------------------------------------

	const int N = 10;
	int A[10] = { 13,28,43,37,10,5,8,99,101,25 };
	int i, j, seged, ertek;

	//rendezetlen tömb kiiratása
	for (i = 0; i < N; ++i)
		cout << A[i] << " ";

	//rendezés közvetlen kiválasztással

	for (i = 0; i < N-1; ++i)
		for (j = i+1; j< N; ++j)
			if (A[i] > A[j])
			{
				seged = A[i];
				A[i] = A[j];
				A[j] = seged;
			}

	//rendezett tömb kiiratás
	

	//rendezett minimum kiiratás

	for (i = 0; i < N-1; ++i)
	{
		seged = i;
		ertek = A[i];
		for (j = 0; j < N; ++j)
			if(ertek > A[j])
		{
				ertek = A[j];
				seged = j;
		}
		A[seged] = A[i];
		A[i] = ertek;
	}

	//buborékos rendezés

	for (i = 0; i < N; ++i)
		for (j = N-1; j >= i; --j)
			if(A[j]<A[j-1])
		{
				seged = A[j - 1];
				A[j - 1] = A[j];
				A[j] = seged;
		}

	//egyszerû beszúrásos rendezés
	for (j = 0; j <N ; j++)
	{
		i = j - 1;
		seged = A[j];
		while (i >= 0 && seged < A[i])
		{
			A[i + 1] = A[i];
			--i;
		}
		A[i + 1] = seged;
	}
	

	
	


	cout << endl;
	for (i = 0; i < N; ++i)
	{
		cout << A[i] << " ";
	}
	cout << endl;

	
	return 0;
}
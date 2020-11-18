
// C++ program to demonstrate vector of pairs 
//#include    <bits/stdc++.h> 

#include "test_pair.h"

using namespace std;

int main()
{
	what_is_vector_pair();

	sorting_vector_ascending();

	sorting_vector_2nd_element();

	return 0;
}

//.............................................................................
/// <summary>
/// https://www.geeksforgeeks.org/sorting-vector-of-pairs-in-c-set-1-sort-by-first-and-second/
/// 
/// What is Vector of Pairs ?
/// 
/// A pair is a container which stores two values mapped to each other, 
/// and a vector containing multiple number of such pairs is called a vector of pairs.
/// </summary>
void what_is_vector_pair()
{
	//declaring vector of pairs 
	vector< pair <int, int> > vect;

	// initialising 1st and 2nd element of 
	// pairs with array values 
	int arr[] = { 10, 20, 5, 40 };
	int arr1[] = { 30, 60, 20, 50 };
	int n = sizeof(arr) / sizeof(arr[0]);

	// Entering values in vector of pairs 
	for (int i = 0; i < n; i++)
		vect.push_back(make_pair(arr[i], arr1[i]));

	// Printing the vector 
	for (int i = 0; i < n; i++)
	{
		// "first" and "second" are used to access 
		// 1st and 2nd element of pair respectively 
		cout << vect[i].first << " "
			<< vect[i].second << endl;
	}

	return;
}

//.............................................................................
/// <summary>
/// https://www.geeksforgeeks.org/sorting-vector-of-pairs-in-c-set-1-sort-by-first-and-second/
/// 
/// Case 1 : Sorting the vector elements on the basis of 
/// first element of pairs in ascending order.
/// 
/// This type of sorting can be achieved using simple "sort()"
/// function.
/// 
/// By default the sort function sorts the vector elements on basis of first element of pairs.
/// </summary>
/// <returns></returns>
int sorting_vector_ascending()
{
	// Declaring vector of pairs 
	vector< pair <int, int> > vect;

	// Initializing 1st and 2nd element of 
	// pairs with array values 
	int arr[]	= { 10, 20, 5, 40 };
	int arr1[]	= { 30, 60, 20, 50 };

	int count = sizeof(arr) / sizeof(arr[0]);

	// Entering values in vector of pairs 
	for (int i = 0; i < count; i++)
		vect.push_back(make_pair(arr[i], arr1[i]));

	// Printing the original vector(before sort()) 
	cout << "The vector before sort operation is:\n";

	for (int i = 0; i < count; i++)
	{
		// "first" and "second" are used to access 
		// 1st and 2nd element of pair respectively 
		cout << vect[i].first << " "
			 << vect[i].second << endl;
	}

	// Using simple sort() function to sort 
	sort(vect.begin(), vect.end());

	// Printing the sorted vector(after using sort()) 
	cout << "The vector after sort operation is:\n";

	for (int i = 0; i < count; i++)
	{
		// "first" and "second" are used to access 
		// 1st and 2nd element of pair respectively 
		cout << vect[i].first	<< " "
			 << vect[i].second	<< endl;
	}

	return 0;
}

//.............................................................................
/// <summary>
/// https://www.geeksforgeeks.org/sorting-vector-of-pairs-in-c-set-1-sort-by-first-and-second/
/// 
/// Driver function to sort the vector elements 
/// by second element of pairs 
/// 
/// </summary>
/// <param name="a"></param>
/// <param name="b"></param>
/// <returns></returns>
bool sortbysec(const pair<int, int>& a, const pair<int, int>& b)
{
	return (a.second < b.second);
}

//.............................................................................
/// <summary>
/// https://www.geeksforgeeks.org/sorting-vector-of-pairs-in-c-set-1-sort-by-first-and-second/
/// 
/// Case 2 : Sorting the vector elements on the basis of 
/// second element of pairs in ascending order.
/// 
/// There are instances when we require to sort the elements of vector 
/// on the basis of second elements of pair.
/// 
/// For that, we modify the sort() functionand we pass a third argument,
/// a call to an user defined explicit function in the sort() function.
/// </summary>
/// <returns></returns>
int sorting_vector_2nd_element()
{
	// declaring vector of pairs 
	vector< pair <int, int> > vect;

	// Initialising 1st and 2nd element of pairs 
	// with array values 
	int arr[] = { 10, 20, 5, 40 };
	int arr1[] = { 30, 60, 20, 50 };
	int n = sizeof(arr) / sizeof(arr[0]);

	// Entering values in vector of pairs 
	for (int i = 0; i < n; i++)
		vect.push_back(make_pair(arr[i], arr1[i]));

	// Printing the original vector(before sort()) 
	cout << "The vector before sort operation is:\n";
	for (int i = 0; i < n; i++)
	{
		// "first" and "second" are used to access 
		// 1st and 2nd element of pair respectively 
		cout << vect[i].first << " "
			<< vect[i].second << endl;

	}

	// Using sort() function to sort by 2nd element 
	// of pair 
	sort(vect.begin(), vect.end(), sortbysec);

	// Printing the sorted vector(after using sort()) 
	cout << "The vector after sort operation is:\n";
	for (int i = 0; i < n; i++)
	{
		// "first" and "second" are used to access 
		// 1st and 2nd element of pair respectively 
		cout << vect[i].first << " "
			<< vect[i].second << endl;
	}
	return 0;
}

//.............................................................................


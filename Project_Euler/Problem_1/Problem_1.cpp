#include <iostream>

int main()
{
	int multiplesOfThree = 0;
	int multiplesOfFive = 0;

	while ( int i = 1; i < 999; i++ ) {
		if (i % 3 == 0) {
			multiplesOfThree += i;
		}
		else if (i % 5 == 0) {
			multiplesOfFive += i;
		}
	}

	int answer = multiplesOfThree + multiplesOfFive;

	std::cout << answer << std::endl;
}
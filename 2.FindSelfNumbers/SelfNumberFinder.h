#pragma once

#include <vector>
#include <string>

class SelfNumberFinder
{
public:
	SelfNumberFinder();
	~SelfNumberFinder();

	int BeginNumber = 0;
	int EndNumber = 0;

	void Init(int begin, int end);
	
	int DoIt();

private:
	int Generate(int n);
};



SelfNumberFinder::SelfNumberFinder()
{
}


SelfNumberFinder::~SelfNumberFinder()
{
}

inline void SelfNumberFinder::Init(int begin, int end)
{
	this->BeginNumber = begin;
	this->EndNumber = end;
}

inline int SelfNumberFinder::Generate(int n)
{
	std::string valueText = std::to_string(n);

	int result = 0;
	for (int i = 0; i < valueText.size(); ++i)
	{
		int digit = valueText[i] - '0';

		result += digit;
	}

	result += n;

	return result;
}

inline int SelfNumberFinder::DoIt()
{
	int sum = 0;
	std::vector<bool> numbers(this->EndNumber, false);	

	for (int i = 1; i < this->EndNumber; ++i)
	{
		int generatedNumber = this->Generate(i);
		if (generatedNumber < this->EndNumber)
		{
			numbers[generatedNumber - 1] = true;
		}

		int numberIndex = i - 1;
		if (numbers[numberIndex] == false)
		{
			sum += i;
		}
	}

	return sum;
}

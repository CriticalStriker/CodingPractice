#pragma once

#include <math.h>

class PagingCalculater
{
public:
	PagingCalculater();
	~PagingCalculater();

	int Calculate(int totalCount, int pageItemCount);

//private:
	int TotalItemCount = 0;
	int PageItemCount = 1;
};



PagingCalculater::PagingCalculater()
{
}


PagingCalculater::~PagingCalculater()
{
}

inline int PagingCalculater::Calculate(int totalCount, int pageItemCount)
{
	if (pageItemCount < 1)
	{
		return -1;
	}

	this->TotalItemCount = totalCount;
	this->PageItemCount = pageItemCount;

	if (this->TotalItemCount <= 0)
	{
		return 0;
	}

	if (this->TotalItemCount <= this->PageItemCount)
	{
		return 1;
	}

	return ceil((float)this->TotalItemCount / (float)this->PageItemCount);
}

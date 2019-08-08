

void MergeLR(int arr[], int first, int middle,int end);
void MergeSort(int arr[], int first, int end);

int main(void) {
	int a[] = {1, 65, 7, 23}, b[] = {4, 53, 6, 38};
	int a_length = sizeof(a) / sizeof(a[0]);
	int b_length = sizeof(b) / sizeof(b[0]);
	int Total_length = a_length + b_length;
	
	int c[(Total_length - 1)];
	int i = 0, j = 0;
	for(i = 0;i < a_length;i++){
		c[i]=a[i];
		j++;
	}
	
	for(i = 0;i < b_length;i++){
		c[j]=b[i];
		j++;
	}
	
	MergeSort(c, 0, (Total_length - 1));
	
	//	���T�{c[]���e�� 
	printf("c[] = {");
	for(i = 0;i < Total_length;i++){
		if(i < Total_length - 1){
			printf("%d, ",c[i]);
		}else{
			printf("%d",c[i]);
		}
	}printf("}");
	return 0;	
}

void MergeLR(int c[], int first, int middle,int end){
	
	int L_length = middle - first + 1;
	int R_length = end - middle;
	int L[L_length];
	int R[R_length];
	
	int i, j;
	for (i = 0; i < L_length; i++){
        L[i] = c[first + i]; 
    }
    for (j = 0; j < R_length; j++){
        R[j] = c[middle + 1+ j];
	}
	int m = 0, n = 0, o = first;	
	while((m < L_length)&&(n < R_length)){
		if(L[m]<=R[n]){
            c[o] = L[m];
            m += 1;            
        }
        else
        {
            c[o] = R[n];
            n += 1;
		}
		o += 1;
    }	
	while(m < L_length){
        c[o] = L[m];
        m += 1;
        o += 1;
    }
    while(n < R_length){
        c[o] = R[n];
        n += 1;
        o += 1;
    }
}

void MergeSort(int c[], int first, int end) {
	if(first < end){
		int middle = (first + end) / 2;
		/*printf(" middle:%d\n",middle);
		printf(" first:%d\n",first);	
	    printf(" end:%d\n\n",end);*/
		MergeSort(c, first, middle);
		MergeSort(c, (middle + 1), end);
		MergeLR(c, first, middle, end);
		
	}	
}

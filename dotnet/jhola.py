def check(arr:list):
    sortedarr = sorted(arr)
    print(sortedarr)

    res = []
    for i in range(len(sortedarr)):
        for j in range (i+1, len(sortedarr)):
            if(arr[i] == arr[j]):
                # print(f"The item is:{arr[i]} and {arr[j]}")
                res.append(arr[j])
                
    print(res)
    
    
    actualarr = []
    for i in range(len(sortedarr)):
        if(sortedarr[i] in res):
            print(sortedarr[i])
            # print(sortedarr[i])
        else:
            actualarr.append(sortedarr[i])
                
            
    print(actualarr)
# check([2,2,1])
check([4,1,2,1,2,5,6,8,8])
# check([1])




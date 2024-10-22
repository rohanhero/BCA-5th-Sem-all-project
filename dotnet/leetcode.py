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
            # print(sortedarr[i])
            pass
            # print(sortedarr[i])
        else:
            actualarr.append(sortedarr[i])
                
            
    print(actualarr)
    
    
    for i in range(len(arr)):
        # if(actualarr[i] in arr[i]):
        if(arr[i] in actualarr):
            print(f"-----------{arr[i]}")
            break
            
# check([2,2,1])
check([0,0,0,0,0,0])
# check([4,1,2,1,2,5,6,8,38,55])
# check([1])




// Given an array of bird sightings where every element represents a bird type id, determine the id of the most frequently sighted type. If more than 1 type has been spotted that maximum amount, return the smallest of their ids.

// Example

// There are two each of types  and , and one sighting of type . Pick the lower of the two types seen twice: type .

// Function Description

// Complete the migratoryBirds function in the editor below.

// migratoryBirds has the following parameter(s):

// int arr[n]: the types of birds sighted
// Returns

// int: the lowest type id of the most frequently sighted birds
// Input Format

// The first line contains an integer, , the size of .
// The second line describes  as  space-separated integers, each a type number of the bird sighted.

// Constraints

// It is guaranteed that each type is , , , , or .
// Sample Input 0

// 6
// 1 4 4 4 5 3
// Sample Output 0

// 4
// Explanation 0

// The different types of birds occur in the following frequencies:

// Type :  bird
// Type :  birds
// Type :  bird
// Type :  birds
// Type :  bird
// The type number that occurs at the highest frequency is type , so we print  as our answer.

// Sample Input 1

// 11
// 1 2 3 4 5 4 3 2 1 3 4
// Sample Output 1

// 3
// Explanation 1

// The different types of birds occur in the following frequencies:

// Type : 
// Type : 
// Type : 
// Type : 
// Type : 
// Two types have a frequency of , and the lower of those is type .

class Result
{
    public static int migratoryBirds(List<int> arr)
    {       
        var order_arr = arr.Order().ToList();        
        Dictionary<int,int> items = new Dictionary<int, int>();
        int count = 0;
        int previous_item = 0;
        int result = 0;
        
        for(int i = 0; i < order_arr.Count(); i++){
            bool key_exist = false;
            
            foreach(var item in items){
                if(order_arr[i] == item.Key){
                    key_exist = true;
                    break;
                }
            }
            
            if(key_exist == false){
                foreach(var type in order_arr){
                    if(type == order_arr[i]){
                        count += 1;
                    }
                }
                            
                items.Add(order_arr[i],count);
                count = 0;
            }
        }
        
        foreach(var item in items){
            if(item.Value > previous_item){
                previous_item = item.Value; 
                result = item.Key;                  
            }
        }
        
        return result;
    }
}
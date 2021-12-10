export default {
    GetCategoryName : function(key){
        switch(key){
            case "NA":
                return "North America";
            case "EU" :
                return "Europe";
            case "AS" :
                return "Asia";
            case "AF" : 
                return "Africa";
            case "SA" : 
                return "South America";
            case "AUS" : 
                return "Australia";
            default :
                return "None";
        }
    }
}
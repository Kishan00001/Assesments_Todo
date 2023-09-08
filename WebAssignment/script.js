class Vehicle{
    constructor(regno,name,category,date,amount){
        this.regno = regno;
        this.name = name;
        this.category = category;
        this.date = date;
        this.amount = amount;
    }
}
class TollPlaza{
    Vehicles =[];
    
    getData(){
        if(localStorage.getItem("vehicles")!=undefined)
            this.Vehicles = JSON.parse(localStorage.getItem("vehicles"));
    }

    addNewEntry =(vh)=>{
        this.getData();
        this.Vehicles.push(vh);
        localStorage.setItem("vehicles",JSON.stringify(this.Vehicles));
    };
    findAmount(vh){
        if(vh=="Bike")
            return 20;
        else if(vh=="LMV")
            return 50;
        else if(vh=="HMV")
            return 80;
        else
            return 100;
    }
    getAllVehicles = () => {
        this.getData();
        return this.Vehicles;
    }
    // updateExpense = (id,ex)=>{
    //     const index = this.expenses.findIndex((e)=>e.id==id)
    //     if(index==-1)
    //         throw "Expense not found to update";
    //     this.expenses.splice(index,1,ex);
    //     localStorage.setItem("all",JSON.stringify(this.expenses))
    // }
    getStringDate(dt){
        return `${dt.getDate()}/${dt.getMonth()+1}/${dt.getFullYear()}`;
    }
    findVehiclesById(id){
        this.getData();
        return this.Vehicles.filter((vh)=>vh.regno.toLowerCase()==id);
    }
    findVehiclesByDate(dt){
        this.getData();
        return this.Vehicles.filter((vh)=>this.getStringDate(dt)==this.getStringDate(new Date(vh.date)));
    } 
    findVehiclesByCategory(cat){
        this.getData();
        return this.Vehicles.filter((vh)=>vh.category.toLowerCase()==cat);
    } 
    
}
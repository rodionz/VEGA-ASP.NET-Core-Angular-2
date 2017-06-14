import { VehicleService } from './../../Services/vehicle.service';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';




@Component({
  selector: 'app-vihicle-form',
  templateUrl: './vihicle-form.component.html',
  styleUrls: ['./vihicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {

  constructor(private vehicleservice : VehicleService,
 ) { }

  makes: any[];

  vehicle: any = {};

  models: any[] = [];

  features: any[];

  ngOnInit() {

     this.vehicleservice.getMakes()
    .subscribe(makes =>  
      this.makes = makes);

      this.vehicleservice.getFeatures()
      .subscribe(feature => this.features = feature)
  }

  onMakeChange() {

     var selectedMake = this.makes.find(m => m.id == this.vehicle.make);   
      this.models = selectedMake ? selectedMake.models : [];
  }



}

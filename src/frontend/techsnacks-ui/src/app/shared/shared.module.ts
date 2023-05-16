import { NgModule } from '@angular/core';
import { MaterialModule } from './modules/material.module';
import { AppFormsModule } from './modules/forms.module';
import { AppRoutingModule } from './modules/app-routing.module';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [
    
  ],
  imports: [
    
  ],
  exports:[
    CommonModule,
    AppRoutingModule,
    AppFormsModule,
    MaterialModule,
  ],
  providers: [],
  bootstrap: [],
})
export class SharedModule {}
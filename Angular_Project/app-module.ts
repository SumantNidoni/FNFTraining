import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { Restolistcomponent } from './Components/restolistcomponent/restolistcomponent';
import { Restodetailcomponent } from './Components/restodetailcomponent/restodetailcomponent';
import { Cartviewcomponent } from './Components/cartviewcomponent/cartviewcomponent';
import { Checkoutcomponent } from './Components/checkoutcomponent/checkoutcomponent';
import { Orderconfirmationcomponent } from './Components/orderconfirmationcomponent/orderconfirmationcomponent';
import {  HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [
    App,
    Restolistcomponent,
    Restodetailcomponent,
    Cartviewcomponent,
    Checkoutcomponent,
    Orderconfirmationcomponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    CommonModule
  ],
  providers: [
    provideBrowserGlobalErrorListeners()
  ],
  bootstrap: [App]
})
export class AppModule { }

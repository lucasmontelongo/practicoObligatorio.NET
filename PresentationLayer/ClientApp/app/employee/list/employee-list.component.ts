import { Component } from '@angular/core';
import { EmployeeService } from '../employee.service';

@Component({
    selector: 'tsi1-employee-list',
    templateUrl: 'employee-list.component.html',
    styleUrls: [ 'employee-list.component.css']
})
export class EmployeeListComponent {
    constructor(employeeService: EmployeeService) {

    }
}

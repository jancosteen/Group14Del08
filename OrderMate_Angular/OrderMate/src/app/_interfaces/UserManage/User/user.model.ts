import {Employee} from '../../EmployeeManage/Employee/employee.model'
import {UserRoles} from '../UserRoles/userroles.model'

export interface User {
    id: string;
    userName:string;
    email:string; 
    password:string;
    confirmPassword:string;
    name:string;
    surname:string;
    contact_Number:number;
    userRoleName:string;
    userRoleIdFk?:string; 
    employeeIdFk?:Employee;
    token?:string; 
    
}
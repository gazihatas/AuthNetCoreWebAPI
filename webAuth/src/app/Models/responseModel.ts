import { ResponseCode } from "../enums/responseCode";

export class ResponseModel{
  public  ResponseCode :ResponseCode=ResponseCode.NotSet;
  public ResponseMessage:string ="";
  public  DateSet :any
}

package banking;

//an exception whose type extends java.lang.Exception but not
//java.lang.RuntimeException is checked at compile time so
//that it only occurs within a try block which catches it or
//in the body of a method which declares to throw it
public class InsufficientFundsException extends Exception {}

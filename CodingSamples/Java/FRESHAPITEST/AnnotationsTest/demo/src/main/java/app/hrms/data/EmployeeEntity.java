package app.hrms.data;
import java.util.Date;

import jakarta.persistence.Basic;
import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.Table;

@Entity
@Table(name = "emp")
public class EmployeeEntity {
    
    @Id
    @Column(name = "empno")
    private int empNo;

    @Basic
    @Column(name = "ename")
    private String ename;

    @Basic
    @Column(name = "job")
    private String job;

    @Basic
    @Column(name = "hiredate")
    private java.util.Date hiredate;


    @Basic
    @Column(name = "sal")
    private double sal;
    
    @Basic
    @Column(name = "deptno")
    private int deptno;

    public int getEmpNo() {
        return empNo;
    }

    public void setEmpNo(int empNo) {
        this.empNo = empNo;
    }

    public String getEname() {
        return ename;
    }

    public void setEname(String ename) {
        this.ename = ename;
    }

    public String getJob() {
        return job;
    }

    public void setJob(String job) {
        this.job = job;
    }

    public java.util.Date getHiredate() {
        return hiredate;
    }

    public void setHiredate(java.util.Date hiredate) {
        this.hiredate = hiredate;
    }

    public double getSal() {
        return sal;
    }

    public void setSal(double sal) {
        this.sal = sal;
    }

    public int getDeptno() {
        return deptno;
    }

    public void setDeptno(int deptno) {
        this.deptno = deptno;
    }

    

    
}


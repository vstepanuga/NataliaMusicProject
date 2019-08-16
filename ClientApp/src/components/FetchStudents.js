import React, { Component } from 'react';

export class FetchStudents extends Component {
    constructor(props) {
        super(props);
        this.state = { students: [], studentCount: 0, loaded: false };

        console.log("FetchStudents is initiated!");

        fetch('api/DatabaseTest/connectionTest')
            .then(result => result.json())
            .then(result => {
                this.setState({
                    students: result,
                    studentCount: result.length,
                    loaded : true
                });
            });
    }


    render() {
        var studentNumber = this.state.studentCount;
        console.log(this.state.students);

        console.log("Total number of students is: " + studentNumber);
        if (!this.state.loaded) {
            return (<h2>
                Loading...
            </h2>);
        } else {
            return (
                <table className='table'>
                    <thead>
                        <tr>
                            <th>Student ID</th>
                            <th>Student Name</th>
                            <th>Student Hyperlink</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.state.students.map(students =>
                            <tr>
                                <td>{students.student_id}</td>
                                <td>{students.name}</td>
                                <td>{students.student_link}</td>
                            </tr>
                        )}
                    </tbody>
                </table>
            );
        }
    }
}
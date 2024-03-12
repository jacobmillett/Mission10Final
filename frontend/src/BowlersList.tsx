import { useEffect, useState } from "react";
import { Bowlers } from "./types/Bowlers";

function BowlersList() {
  const [bowlerData, setBowlerData] = useState<Bowlers[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch("http://localhost:5217/api/Bowler");
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <div>
        <table className="table mx-auto table-bordered">
          <thead>
            <tr>
              <th>Bowler Name</th>
              <th>Team Name</th>
              <th>Address</th>
              <th>City</th>
              <th>State</th>
              <th>Zip</th>
              <th>Phone Number</th>
            </tr>
          </thead>
          <tbody>
            {bowlerData.map((b) => (
              <tr key={b.bowlerID}>
                <td>
                  {b.bowlerFirstName} {b.bowlerMiddleInit} {b.bowlerLastName}
                </td>
                <td>{b.teamName?.teamName}</td>
                <td>{b.bowlerAddress}</td>
                <td>{b.bowlerCity}</td>
                <td>{b.bowlerState}</td>
                <td>{b.bowlerZip}</td>
                <td>{b.bowlerPhoneNumber}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </>
  );
}

export default BowlersList;

export class VideoStore {

    filmLibrary: Map<string,string> = new Map();
    
    rentVideo(filmTitle: string, customer: string): Boolean {
        if (this.filmLibrary.has(filmTitle) === true) {
            return false
        }

        for (const [title, rentedBy] of this.filmLibrary.entries()) {
            if (rentedBy === customer) {
                return false
            }
        }

        this.filmLibrary.set(filmTitle,customer);
        return true
    }
}